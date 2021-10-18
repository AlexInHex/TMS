using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Commands
{
    class AddCommand : Command
    {

        public AddCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new AddValidator(parametrs);
        }

        public override string Execute()
        {     
            
            for (int i = 0; i < parametrs.Length - 1; i++)
            {
                if (parametrs[i] == null)
                {
                    return "Введены не все параметры команды add.";
                }
            }

            string newStudentName = parametrs[1];
            string newStudentSurname = parametrs[2];
            string newStudentGender = parametrs[3];
            int newStudentAge = int.Parse(parametrs[4]);

            Student newStudent = new Student(newStudentName, newStudentSurname, newStudentGender, newStudentAge);

            var result = repository.Add(newStudent);

            return result != 0 ? "Студент создан" : "Студент не создан";            
        }
    }
}
