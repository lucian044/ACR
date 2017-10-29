using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.DataModels
{
    public class Week
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime WeekStart { get; set; } 
        [Required]
        public DateTime WeekEnd { get; set; }
        [Required]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; } 
        [Required]
        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        [Required]
        public int Quarter { get; set; }
        public int Mon { get; set; }
        public int Tue { get; set; }
        public int Wed { get; set; }
        public int Thurs { get; set; }
        public int Fri { get; set; }

    }
}