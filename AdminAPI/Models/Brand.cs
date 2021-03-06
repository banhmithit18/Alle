using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Brand")]
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int")]
        public int id { get; set; }


        [Column("BrandName", TypeName = "varchar")]
        public String BrandName { get; set; }
        [StringLength(100)]


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }






    }

}
