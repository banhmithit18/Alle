using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Product_Image")]
    public class Product_Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }


        [Column("product_detail", TypeName = "int")]
        public int product_detail { get; set; }


        [Column("path", TypeName = "varchar")]
        public string path { get; set; }
        [StringLength(300)]


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }








    }

}
