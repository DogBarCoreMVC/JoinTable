using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace JoinTable.Models.DB
{
    public partial class ProductsTbl
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? CategoryId { get; set; }

        
        public CategoriesTbl Category { get; set; }//เรียกใช้งาน Class CategoriesTbl
    }
}
