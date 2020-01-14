using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class Room
    {
        public Room()
        {
            Document = new HashSet<Document>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int ApartmentId { get; set; }
        public int Area { get; set; }
        public bool Furnished { get; set; }
        public int MonthlyAmount { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime MoveInDate { get; set; }

        public virtual Apartment Apartment { get; set; }
        public virtual User User { get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
