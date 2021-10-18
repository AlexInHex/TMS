using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class ListCommand : Command
    {
        public ListCommand(Repository repository, string[] parametrs)
           : base(repository, parametrs)
        { }

        public override string Execute()
        {           
            var list = repository.List();

            if (list.Length == 0)
            {
                return "список пуст";
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var student in list)
                {
                    stringBuilder.AppendLine(student.ToString());
                }

                return stringBuilder.ToString();
            }            
        }
    }
}
