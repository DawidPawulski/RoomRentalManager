using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Apartment
    {
        public Apartment()
        {
            ApartmentInfo = new HashSet<ApartmentInfo>();
            Room = new HashSet<Room>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int NumberOfRooms { get; set; }
        public bool SmokingAllowed { get; set; }
        public bool PetsAllowed { get; set; }
        public DateTime YearOfRenovation { get; set; }
        public int Floor { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public int Area { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ApartmentInfo> ApartmentInfo { get; set; }
        public virtual ICollection<Room> Room { get; set; }
    }
}
