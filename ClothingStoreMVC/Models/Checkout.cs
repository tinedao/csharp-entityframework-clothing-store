using System;
using System.Collections.Generic;

namespace ClothingStoreMVC.Models
{
    public partial class Checkout
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Payment { get; set; }
        public string Shipcode { get; set; }
        public int? Idcart { get; set; }

        public Users IdUserNavigation { get; set; }
        public Cart IdcartNavigation { get; set; }
    }
}
