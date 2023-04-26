using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClothingStoreMVC.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            Wishlist = new HashSet<Wishlist>();
        }

        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Đánh giá")]
        public double? Star { get; set; }
        [DisplayName("Giá")]
        public decimal? Price { get; set; }
        [DisplayName("Kích cỡ")]
        public string Size { get; set; }
        [DisplayName("Màu")]
        public string Color { get; set; }
        [DisplayName("Số lượng")]
        public int? Quantity { get; set; }
        public int? IdCate { get; set; }
        [DisplayName("Loại")]
        public virtual Category Category { get; set; }
        public Category IdCateNavigation { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Wishlist> Wishlist { get; set; }
    }
}
