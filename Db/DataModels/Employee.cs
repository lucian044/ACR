using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.DataModels
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [ForeignKey("School")]
        public int SchoolID { get; set; }    
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string GradeSubject { get; set; }
        [Required]
        public bool NewEmployee { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public Role Role { get; set; }

    }
}