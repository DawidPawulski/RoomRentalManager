using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Request
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public int UserId { get; set; }
        public DateTime SendDate { get; set; }

        public virtual Advertisement Advertisement { get; set; }
        public virtual User User { get; set; }
    }
}
