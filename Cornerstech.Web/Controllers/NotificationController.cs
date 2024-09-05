using Cornerstech.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cornerstech.Web.Controllers
{
    public class NotificationController : Controller
    {
        private INotificationService _notificationService;
        private INotificationApplicationUserService _notificationApplicationUserService;
        private IUserService _userService;

        public NotificationController(INotificationService notificationService,
                                        IUserService userService, INotificationApplicationUserService notificationApplicationUserService)
        {
            _notificationService = notificationService;
            _userService = userService;
            _notificationApplicationUserService = notificationApplicationUserService;
        }

        public IActionResult Index(string term, bool showAll = false)
        {
            var userId = _userService.GetUserId(HttpContext.User); // Retrieves the current user's ID
            if (userId == null)
            {
                return BadRequest("User ID not found.");
            }

            var userNotifications = _notificationApplicationUserService.GetUserNotifications(userId.Value).ToList();

            // Joins user notifications with the corresponding 
            var notifications = (from nApplicationUser in userNotifications
                                 join notification in _notificationService.TGetList()
                                 on nApplicationUser.NotificationId equals notification.Id
                                 select new
                                 {
                                     Notification = notification,
                                     NotificationApplicationUser = nApplicationUser
                                 }).ToList();

            if (!showAll) // Filters out read notifications if showAll is false

            {
                notifications = notifications.Where(n => !n.NotificationApplicationUser.IsRead).ToList();
            }

            if (!string.IsNullOrEmpty(term)) // Filters notifications by search term if provided

            {
                notifications = notifications.Where(n => n.Notification.Text.Contains(term)).ToList();
            }

            return View(notifications);
        }


        [HttpPost]
        public IActionResult MarkAsRead(int id, string term, bool showAll = false) // Marks a specific notification as read

        {
            var notificationApplicationUser = _notificationApplicationUserService.TGetByID(id);

            if (notificationApplicationUser == null)
            {
                return NotFound();
            }

            // Marks the notification as read if the user is authenticated
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (int.TryParse(userId, out int parsedUserId))
            {
                notificationApplicationUser.IsRead = true;

                _notificationApplicationUserService.TUpdate(notificationApplicationUser);
            }

            return RedirectToAction("Index", new { term = term, showAll = showAll });
        }

    }

}