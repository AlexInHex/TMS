using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;

namespace StudentConsoleHWApp.Validator
{ 
        public interface IValidator
        {
            public bool Validate();
            public string ErrorMessage { get;}
        }
    
}
