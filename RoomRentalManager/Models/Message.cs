using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Message
    {
        public Message()
        {
            ReceiversMessages = new HashSet<ReceiversMessages>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ReceiversMessages> ReceiversMessages { get; set; }
    }
}
