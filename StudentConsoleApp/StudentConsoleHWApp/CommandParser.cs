using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Commands;
using StudentConsoleHWApp;
using StudentConsoleHWApp.Validator;

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
            var inpurArr = input.Split(" ");
            string[] parametrs = new string[6];
            int index = 0;            



            foreach (var item in inpurArr)
            {
                if (!string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }

            if (parametrs[0] == null)
            {
                return new UnknownCommand(repository, parametrs);
            }
            else
            {
                switch (parametrs[0].ToUpper())
                {
                    case "ADD":
                        return new AddCommand(repository, parametrs);
                    case "EDIT":
                        return new EditCommand(repository, parametrs);
                    case "LIST":
                        return new ListCommand(repository, parametrs);
                    case "DELETE":
                        return new DeleteCommand(repository, parametrs);
                    case "FIND":
                        return new FindCommand(repository, parametrs);
                    case "GET":
                        return new GetCommand(repository, parametrs);
                    case "RANDOM":
                        return new RandomCommand(repository, parametrs);
                    default:
                        return new UnknownCommand(repository, parametrs);
                }
            }
        }
    }
}