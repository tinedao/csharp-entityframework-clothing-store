using System;
using System.Collections.Generic;

namespace ClothingStoreMVC.Models
{
    public partial class Users
    {
        public Users()
        {
            Checkout = new HashSet<Checkout>();
            Preview = new HashSet<Preview>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Checkout> Checkout { get; set; }
        public ICollection<Preview> Preview { get; set; }
    }
}
