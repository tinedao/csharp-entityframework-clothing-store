using System;
using System.Collections.Generic;

namespace ClothingStoreMVC.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            Wishlist = new HashSet<Wishlist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Star { get; set; }
        public decimal? Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int? Quantity { get; set; }
        public int? IdCate { get; set; }

        public Category IdCateNavigation { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Wishlist> Wishlist { get; set; }
    }
}
