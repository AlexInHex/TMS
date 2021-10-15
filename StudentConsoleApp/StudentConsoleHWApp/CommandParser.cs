using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Commands;
using StudentConsoleHWApp;

namespace StudentsConsoleApp
{
    class CommandsParser
    {
        private Repository repository;

        public CommandsParser(Repository repository)
        {
            this.repository = repository;
        }

        public Command Parse(string input)
        {
            var inpurArr = input.Split();
            string[] parametrs = new string[4];
            int index = 0;

            foreach (var item in inpurArr)
            {
                if (string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }

            switch (parametrs[0].ToUpper())
            {
                case "ADD":
                    return new AddCommand(repository, parametrs);
                    break;
                default:
                    return new Command(repository, parametrs);
            }


        }
    }
}