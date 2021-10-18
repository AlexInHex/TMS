using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Validator
{
    internal class GetValidator : BaseValidator
    {
        public GetValidator(string[] parametrs)
            : base(parametrs)
        { }

        public override bool Validate()
        {
            return (IdValidation(param[1]));          
        }

    }
}
