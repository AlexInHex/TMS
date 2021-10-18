using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Commands
{
    class EditCommand : Command
    {
        public EditCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new EditValidator(parametrs);
        }

        public override string Execute()
        {

            for (int i = 0; i < parametrs.Length; i++)
            {
                if (parametrs[i] == null)
                {
                    return "Введены не все параметры команды edit.";
                }
            }

                Student student = new Student(
               int.Parse(parametrs[1]),
               parametrs[2],
               parametrs[3],
               parametrs[4],
               int.Parse(parametrs[5])
               );

                bool result = repository.Edit(student);

                return result ? "Студент изменен" : $"Студент {parametrs[1]} Не найден";
        }
    }
}
