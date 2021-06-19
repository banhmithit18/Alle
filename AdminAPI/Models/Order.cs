using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("UserId", TypeName = "int")]
        public int UserId { get; set; }


        [Column("Discount", TypeName = "int")]
        public int Discount { get; set; }


        [Column("Total", TypeName = "float")]
        public double Total { get; set; }


        [Column("OrderDate", TypeName = "datetime")]
        public string OrderDate { get; set; }





    }

}
