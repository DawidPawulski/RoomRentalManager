using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Document
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int TenantId { get; set; }
        public int? RoomId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }

        public virtual User Owner { get; set; }
        public virtual Room Room { get; set; }
        public virtual User Tenant { get; set; }
    }
}
