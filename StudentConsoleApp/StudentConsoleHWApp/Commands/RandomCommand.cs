using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class RandomCommand : Command
    {
        public RandomCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        { }

            public override string Execute()
        { 
            Student[] students = repository.List();

            if (students.Length == 0)
            {
                return "Нет студентов";
            }

            Random rnd = new Random();
            int index = rnd.Next(0, students.Length);

            return students[index].ToString();
        }
    }
}
