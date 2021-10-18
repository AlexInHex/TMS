using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Commands
{
    abstract class Command
    {
        public string[] parametrs;
        public Repository repository;
        public IValidator validator;
        
        public Command(Repository repository, string[] parametrs)

        {
            this.parametrs = parametrs;
            this.repository = repository;
            
        }

        public abstract string Execute();


        public string ExecutWithValidate()
        {
            if (validator == null)
            {
                return Execute();
            }
            else if (validator.Validate())
            {
                return Execute();
            }
            else
            {
                return validator.ErrorMessage;
            }
        }
            
    }
}
