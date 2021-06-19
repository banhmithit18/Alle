using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("Title", TypeName = "varchar")]
        public string Title { get; set; }
        [StringLength(300)]


        [Column("Content", TypeName = "varchar")]
        public string Content { get; set; }


        [Column("Email", TypeName = "varchar")]
        public string Email { get; set; }
        [StringLength(300)]


        [Column("Date", TypeName = "datetime")]
        public string Date { get; set; }


        [Column("Status", TypeName = "bit")]
        public bool Status { get; set; }






    }

}
