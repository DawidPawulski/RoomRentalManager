using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? RoomId { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}
