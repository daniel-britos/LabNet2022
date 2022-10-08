using EntityFramework.Lab.Entities;
using EntityFramework.Lab.MVC.Models.Validations;
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
        [Required(ErrorMessage = "The name of company is required.")]
        [CapitalizeAttribute] //validación custom
        [UpperCaseAttribute] //validación custom
        [SymbolsAttribute] //validación custom
        [StringLength(24)]
        public string NameOfCompany { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "The phone number is required.")]
        [MinLength(10, ErrorMessage = "You must enter 10 numbers, example: '1512345678'")]
        [MaxLength(10, ErrorMessage = "You must enter 10 numbers, example: '1112345678'")]
        public string PhoneNumber { get; set; }

    }
}