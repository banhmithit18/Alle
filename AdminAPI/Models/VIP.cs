using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("VIP")]
    public class VIP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("VipName", TypeName = "varchar")]
        public string VipName { get; set; }
        [StringLength(100)]


        [Column("AmountNeeded", TypeName = "float")]
        public double AmountNeeded { get; set; }


        [Column("Discount", TypeName = "int")]
        public int Discount { get; set; }


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }





    }

}
