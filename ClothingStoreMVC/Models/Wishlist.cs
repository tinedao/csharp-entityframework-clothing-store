using System;
using System.Collections.Generic;

namespace ClothingStoreMVC.Models
{
    public partial class Wishlist
    {
        public int Id { get; set; }
        public int? IdPro { get; set; }

        public Product IdProNavigation { get; set; }
    }
}
