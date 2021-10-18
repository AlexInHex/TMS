using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Validator
{
    internal class EditValidator : BaseValidator
    {
        public EditValidator(string[] parametrs)
            : base(parametrs)
        { }

        public override bool Validate()
        {           
                return IdValidation(param[1]) && NameValidation(param[2]) &&
                                SurnameValidation(param[3]) && GenderValidation(param[4]) && AgeValidation(param[5]);
        }      
    }
}
