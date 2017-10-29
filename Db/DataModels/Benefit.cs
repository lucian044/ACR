using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.DataModels
{
    public class Benefit
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; } 
        [Required]
        public double Salary { get; set; }
        [Required]
        public double pSocialSecurity { get; set; }
        [Required]
        public double pWokersComp { get; set; }
        [Required]
        public double pUnemployment { get; set; }
        [Required]
        public double pLayPersonsRetirement { get; set; }
        [Required]
        public double ReligiousRetirement { get; set; }
        [Required]
        public double Other { get; set; }
        [Required]
        public double MedicalBenefits { get; set; }
        [Required]
        public double MedicalContribution { get; set; }
        [Required]
        public double OtherSalary { get; set; }
        [Required]
        public int Days { get; set; }
        [Required]
        public int HoursPerDay { get; set; }
        [Required]
        public double FirstHalf { get; set; }

    }
}