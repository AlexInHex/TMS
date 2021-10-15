using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp
{
    class Student
    {
        private string name;
        private string surname;
        private string gender;
        private int age;
        private int id;

        public string Name
        {
            get 
            {
                return name;
            }           
        
        }
        public string Surname
        {
            get
            {
                return surname;
            }

        }
        public string Gender
        {
            get
            {
                return gender;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                
            }

        }

        public Student(int id, string n, string surN, string g, int a)
        {
            n = name;
            surN = surname;
            g = gender;
            a = age;
            this.id = id;
        }

        public Student(string n, string surN, string g, int a): this (0, n, surN, g, a)
        {
            n = name;
            surN = surname;
            g = gender;
            a = age;
            
        }
    }
}
