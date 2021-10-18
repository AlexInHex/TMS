using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp
{
    class Repository
    {        
        public static Student[] students = new Student[10];
        private int nextId = 1;
        

        public int Add(Student student)
        {            
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    student.Id = nextId;                    
                    students[i] = student;

                    return nextId++;
                }                
            }
            return 0;
        }

        public bool Edit(Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (student.Id == students[i]?.Id)
                {
                    students[i].Update(student);

                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (id == students[i]?.Id)
                {
                    students[i] = null;
                    return true;
                }
            }
            return false;
        }

        public Student Get(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (id == students[i]?.Id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public Student[] Find(string substring)
        {
            Student[] result = new Student[students.Length];
            int count = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]?.Name?.Contains(substring, StringComparison.OrdinalIgnoreCase) == true ||
                    students[i]?.Surname?.Contains(substring, StringComparison.OrdinalIgnoreCase) == true)
                {
                    result[count++] = students[i];                    
                }
            }

            Array.Resize(ref result, count);
            return result;
        }

        public Student[] List()
        {
            Student[] result = new Student[students.Length];
            int count = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    result[count++] = students[i];                    
                }
            }

            Array.Resize(ref result, count);
            return result;
        }                   
    }
}
