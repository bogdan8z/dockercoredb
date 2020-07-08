using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApi.Models
{
    public partial class Products
    {
        [Column("ID")]
        public int? Id { get; set; }
        public string ProductName { get; set; }
    }
}
