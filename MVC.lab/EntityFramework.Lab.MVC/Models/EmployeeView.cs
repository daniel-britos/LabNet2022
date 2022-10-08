using EntityFramework.Lab.MVC.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework.Lab.MVC.Models
{
    public class EmployeeView //: IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [CapitalizeAttribute] //validación custom
        [UpperCaseAttribute] //validación custom
        [SymbolsAttribute] //validación custom
        [StringLength(24)]
        [Required(ErrorMessage = "The name is required.")]
        public string Name { get; set; }

        [CapitalizeAttribute] 
        [UpperCaseAttribute]
        [SymbolsAttribute]
        [StringLength(24)]
        [Required(ErrorMessage = "The last name is required.")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "The phone number is required.")]
        [MinLength(10, ErrorMessage = "You must enter 10 numbers, example: '1512345678'")]
        [MaxLength(10, ErrorMessage = "You must enter 10 numbers, example: '1112345678'")]
        public string Phone { get; set; }

    }
}

/*

        //Validación a nivel del modelo para determinar la primera letra ingresada como mayuscula.
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name != null && Name.Length > 0)
            {
                var letter = Name[0].ToString();
                if(letter != letter.ToUpper())
                {
                    yield return new ValidationResult("The first letter must be uppercase",
                        new[] { nameof(Name) });
                }
            }

            if (LastName != null && LastName.Length > 0)
            {
                var letter = LastName[0].ToString();
                if (letter != letter.ToUpper())
                {
                    yield return new ValidationResult("The first letter must be uppercase",
                        new[] { nameof(LastName) });
                }
            }
        }
        



*/