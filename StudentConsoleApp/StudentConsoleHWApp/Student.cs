using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp
{
    class Student
    {
       /*private string name;
        private string surname;
        private string gender;
        private int age;
        private int id;*/

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; private set;}
        public int Id { get; set; }            

        public Student(int idStudent, string nameStudent, string surNameStudent, string genderStudent, int ageStudent)
        {
            Name = nameStudent;
            Surname = surNameStudent;
            Gender = genderStudent;
            Age = ageStudent;
            Id = idStudent;
        }

        public Student(string nameStudent, string surNameStudent, string genderStudent, int ageStudent)
            : this (0, nameStudent, surNameStudent, genderStudent, ageStudent)
        {
           /* Name = nameStudent;
            Surname = surNameStudent;
            Gender = genderStudent;
            Age = ageStudent;*/

        }

        public void Update(Student student)
        {
            Name = student.Name;
            Surname = student.Surname;
            Gender = student.Gender;
            Age = student.Age;
        }

        public override string ToString()
        {
            return $"ID студента: {Id}, имя: {Name}, фамилия: {Surname}, пол: {Gender}, возраст: {Age}. ";
        }
    }
}
