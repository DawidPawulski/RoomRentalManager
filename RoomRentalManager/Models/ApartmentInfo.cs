using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class ApartmentInfo
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public virtual Apartment Apartment { get; set; }
    }
}
