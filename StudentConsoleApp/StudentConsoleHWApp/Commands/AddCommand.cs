using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class AddCommand : Command
    {

        public AddCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        { }

        public override string Execute()
        {
            
            string userText = Console.ReadLine();
            string[] parametrs = userText.Split(',');
            
                        
            string newStudentName = parametrs[0];
            string newStudentSurname = parametrs[1];
            string newStudentGender = parametrs[2];
            int newStudentAge = int.Parse(parametrs[3]);

            Student newStudent = new Student(newStudentName, newStudentSurname, newStudentGender, newStudentAge);


            return "Студент создан";
            


            


            
            

            
        }
    }
}
