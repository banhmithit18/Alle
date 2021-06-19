using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Product_Detail")]
    public class Product_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("Product", TypeName = "int")]
        public int Product { get; set; }


        [Column("Quantity", TypeName = "int")]
        public int Quantity { get; set; }


        [Column("Color", TypeName = "varchar")]
        public string Color { get; set; }
        [StringLength(100)]


        [Column("Size", TypeName = "varchar")]
        public string Size { get; set; }
        [StringLength(50)]


        [Column("Product_Image", TypeName = "int")]
        public int Product_Image { get; set; }


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }








    }

}
