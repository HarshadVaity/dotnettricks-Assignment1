using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.CustomValidation
{
    public class ValidateCheckBox : ValidationAttribute, IClientModelValidator
    {
        public override bool IsValid(object value) // server side
        {
            return (bool)value;
        }

        public void AddValidation(ClientModelValidationContext context) // client side
        {
            context.Attributes.Add("data-val-forCheckBox", ErrorMessage);
        }
    }
}
