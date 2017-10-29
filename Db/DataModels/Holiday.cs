using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.DataModels
{
    public class Holiday
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("School")]
        public int SchoolID { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }


    }
}