﻿namespace Cornerstech.EntityLayer.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Partner Partner { get; set; }
        public List<NotificationApplicationUser> NotificationApplicationUsers { get; set; }
    }
}
