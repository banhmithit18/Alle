using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models
{

    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }



        [Column("Name", TypeName = "varchar")]
        public string Name { get; set; }
        [StringLength(200)]


        [Column("Age", TypeName = "int")]
        public int Age { get; set; }


        [Column("Gender", TypeName = "varchar")]
        public string Gender { get; set; }
        [StringLength(20)]


        [Column("Email", TypeName = "varchar")]
        public string Email { get; set; }
        [StringLength(300)]


        [Column("Phone", TypeName = "varchar")]
        public string Phone { get; set; }
        [StringLength(20)]


        [Column("Address", TypeName = "varchar")]
        public string Address { get; set; }
        [StringLength(500)]


        [Column("VIP", TypeName = "int")]
        public int VIP { get; set; }


        [Column("SpentAmount", TypeName = "float")]
        public double SpentAmount { get; set; }


        [Column("Username", TypeName = "varchar")]
        public string Username { get; set; }
        [StringLength(300)]


        [Column("Password", TypeName = "varchar")]
        public string Password { get; set; }


        [Column("RegistrationDate", TypeName = "datetime")]
        public string RegistrationDate { get; set; }


        [Column("Active", TypeName = "bit")]
        public bool Active { get; set; }













    }

}
