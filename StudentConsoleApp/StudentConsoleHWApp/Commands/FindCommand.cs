using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Commands
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new FindValidator(parametrs);
        }

        public override string Execute()
        {                                  
            return $"Найдено {repository.Find(parametrs[1])} студентов. ";
        }
    }
}
