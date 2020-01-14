using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class UsersNotifications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int NotificationId { get; set; }

        public virtual Notification Notification { get; set; }
        public virtual User User { get; set; }
    }
}
