using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Discount")]
    public class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("DiscountCode", TypeName = "varchar")]
        public string DiscountCode { get; set; }
        [StringLength(300)]


        [Column("DiscountPrice", TypeName = "int")]
        public int DiscountPrice { get; set; }


        [Column("Reusable", TypeName = "bit")]
        public bool Reusable { get; set; }


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }






    }

}
