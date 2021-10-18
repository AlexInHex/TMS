using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Validator
{
    internal class DeleteValidator : BaseValidator
    {
        public DeleteValidator(string[] parameters) : base(parameters)
        { }

        public override bool Validate()
        {
            return IdValidation(param[1]);
           
        }        
    }
}
