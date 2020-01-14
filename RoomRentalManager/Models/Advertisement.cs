using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            Image = new HashSet<Image>();
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? RoomId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Room Room { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<Request> Request { get; set; }
    }
}
