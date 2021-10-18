using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Validator
{
    internal class AddValidator : BaseValidator
    {

        public AddValidator(string[] param)
            : base(param)
        { 
        
        }


        public override bool Validate()
        {                       
            return (NameValidation(param[1]) && SurnameValidation(param[2]) &&
                GenderValidation(param[3]) && AgeValidation(param[4]));           
        }        
    }
}
