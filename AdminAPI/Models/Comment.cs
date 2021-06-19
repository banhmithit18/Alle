using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("Content", TypeName = "varchar")]
        public string Content { get; set; }


        [Column("User", TypeName = "int")]
        public int User { get; set; }


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }




    }

}
