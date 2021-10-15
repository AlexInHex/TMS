using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp
{



    class Repository
    {
        internal static Repository repository;
        public static Student[] students = new Student[10];
        private int nextId = 1;
        

        public Status Add(Student student)
        {            
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    student.Id = nextId;
                    nextId++;

                    students[i] = student;

                    return Status.Yes;
                }                
            } 
            return Status.No;
        }
    }
}
