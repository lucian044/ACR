using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.DataModels
{
    public class School
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        [StringLength(255)]
        public int City { get; set; }    
        [Required]
        [StringLength(255)]
        public string State { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        [StringLength(255)]
        public string District { get; set; }
        [Required]
        public int Contract { get; set; }
        [Required]
        public int IRN { get; set; }
        [Required]
        public int ADM { get; set; }
        [Required]
        public double CostEmp { get; set; }
        [Required]
        public int NumEmployee { get; set; }
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string Fax { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }


    }
}