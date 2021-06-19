using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("ProductName", TypeName = "varchar")]
        public string ProductName { get; set; }
        [StringLength(200)]


        [Column("Price", TypeName = "float")]
        public double Price { get; set; }


        [Column("Brand", TypeName = "int")]
        public int Brand { get; set; }


        [Column("Category", TypeName = "int")]
        public int Category { get; set; }


        [Column("Type", TypeName = "int")]
        public int Type { get; set; }



        [Column("Description", TypeName = "varchar")]
        public string Description { get; set; }


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }








    }

}
