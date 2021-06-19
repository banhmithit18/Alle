using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("ImportLog")]
    public class ImportLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("Product_Detail", TypeName = "int")]
        public int Product_Detail { get; set; }


        [Column("Quantity", TypeName = "int")]
        public int Quantity { get; set; }


        [Column("ImportDate", TypeName = "datetime")]
        public string ImportDate { get; set; }




    }

}
