using System;
using System.Collections.Generic;

namespace ClothingStoreMVC.Models
{
    public partial class Preview
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Preview1 { get; set; }

        public Users IdUserNavigation { get; set; }
    }
}
