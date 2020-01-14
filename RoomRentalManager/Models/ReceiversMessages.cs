using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class ReceiversMessages
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MessageId { get; set; }

        public virtual Message Message { get; set; }
        public virtual User User { get; set; }
    }
}
