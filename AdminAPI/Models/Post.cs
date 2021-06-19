using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("Title", TypeName = "varchar")]
        public string Title { get; set; }
        [StringLength(500)]


        [Column("Content_Path", TypeName = "varchar")]
        public string Content_Path { get; set; }
        [StringLength(300)]


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }




    }

}
