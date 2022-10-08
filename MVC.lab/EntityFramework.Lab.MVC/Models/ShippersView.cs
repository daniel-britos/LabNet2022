using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework.Lab.MVC.Models
{
    public class ShippersView
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(24)]
        public string NameOfCompany { get; set; }

        [StringLength(24)]
        public string PhoneNumber { get; set; }

    }
}