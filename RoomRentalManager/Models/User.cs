using System;
using System.Collections.Generic;

namespace RoomRentalManager.Models
{
    public partial class User
    {
        public User()
        {
            Apartment = new HashSet<Apartment>();
            DocumentOwner = new HashSet<Document>();
            DocumentTenant = new HashSet<Document>();
            Message = new HashSet<Message>();
            Payment = new HashSet<Payment>();
            ReceiversMessages = new HashSet<ReceiversMessages>();
            Request = new HashSet<Request>();
            Room = new HashSet<Room>();
            UsersNotifications = new HashSet<UsersNotifications>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalDocumentNumber { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Apartment> Apartment { get; set; }
        public virtual ICollection<Document> DocumentOwner { get; set; }
        public virtual ICollection<Document> DocumentTenant { get; set; }
        public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<ReceiversMessages> ReceiversMessages { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Room> Room { get; set; }
        public virtual ICollection<UsersNotifications> UsersNotifications { get; set; }
    }
}
