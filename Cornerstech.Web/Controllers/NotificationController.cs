using Cornerstech.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
            var userId = _userService.GetUserId(HttpContext.User);
            if (userId == null)
            {
                return BadRequest("User ID not found.");
            }

            var notifications = (from notification in _notificationService.GetUserNotifications(userId.Value)
                                 join nApplicationUser in _notificationApplicationUserService.TGetList()
                                 on notification.Id equals nApplicationUser.NotificationId into nApplicationUsers
                                 from nApplicationUser in nApplicationUsers.DefaultIfEmpty()
                                 select new
                                 {
                                     Notification = notification,
                                     NotificationApplicationUser = nApplicationUser
                                 }).ToList();


            return View(notifications);
        }

        [HttpPost]
        public IActionResult MarkAsRead(int id)
        {
            try
            {
                var notificationApplicationUser = _notificationApplicationUserService.TGetByID(id);

                if (notificationApplicationUser == null)
                {
                    return NotFound();
                }

                notificationApplicationUser.IsRead = true;

                _notificationApplicationUserService.TUpdate(notificationApplicationUser);

                return RedirectToAction("Index");
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}