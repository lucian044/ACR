using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.DataModels
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }
        [Required]
        public int CategoryNumber { get; set; }

    }
}