using System;
using System.Collections.Generic;

namespace ClothingStoreMVC.Models
{
    public partial class Cart
    {
        public Cart()
        {
            Checkout = new HashSet<Checkout>();
        }

        public int Id { get; set; }
        public int? IdPro { get; set; }
        public decimal? Total { get; set; }

        public Product IdProNavigation { get; set; }
        public ICollection<Checkout> Checkout { get; set; }
    }
}
