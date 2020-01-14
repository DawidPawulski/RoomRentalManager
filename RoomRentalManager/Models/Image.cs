using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public string Source { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
