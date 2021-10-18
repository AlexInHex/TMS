using System;
using StudentsConsoleApp;

namespace StudentConsoleHWApp
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Repository repository = new Repository();           

            Console.WriteLine("Список команд: add - добавить студента, edit - изменить студента, delete - удалить студента, " +
                "find - найти студента, get - получить студента по id, list - вывести всех студентов," +
                " random - получить случайного студента. ");                           

            while (true)
            {
                string input = Console.ReadLine();
                var parser = new CommandsParser(repository);
                var command = parser.Parse(input);
                var result = command.ExecutWithValidate();
                Console.WriteLine(result);
            }
            
        }
    }
}
