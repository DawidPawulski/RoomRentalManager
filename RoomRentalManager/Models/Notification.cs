using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Notification
    {
        public Notification()
        {
            UsersNotifications = new HashSet<UsersNotifications>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<UsersNotifications> UsersNotifications { get; set; }
    }
}
