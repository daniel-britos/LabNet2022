using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework.Lab.Api.Models
{
    public class EmployeesView
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        
        [Required]
        public string Phone { get; set; }
    }
}