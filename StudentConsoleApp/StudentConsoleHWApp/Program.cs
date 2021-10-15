using System;
using StudentConsoleHWApp.Commands;

namespace StudentConsoleHWApp
{
    class Program
    {

        CommandParser commandParser = new CommandParser();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Список команд: add - добавить студента, edit - изменить студента, ");

            string command;
            while (true)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        {
                            AddCommand.Execute();
                            break;
                        }
                    case "edit":
                        {
                            
                            break;
                        }
                
                }

            }
            
        }
    }
}
