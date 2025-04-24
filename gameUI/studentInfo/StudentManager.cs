using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInfo
{
    public class StudentManager
    {
        List<Student> students = new List<Student>();
        int index = 0;

        public StudentManager() 
        {
            ReadFromFile();
            students.Add(new Student("Fred", "123 Rock Way", "Fred@gmail.com"));
            students.Add(new Student("Barney", "2345 Rock Way", "barney@gmail.com"));
            students.Add(new Student("Wilma", "4576 Rock Way", "wilma@gmail.com"));
            students.Add(new Student("Betty", "67856 Rock Way", "betty@gmail.com"));
        }

        public Student GetStudent()
        {
            if (index >= students.Count)
            {
                index = 0;
            }

            return students[index++];
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            WriteToFile();
        }

        private void ReadFromFile()
        {
        }

        private void WriteToFile()
        {
        }

        private void SortStudent()
        {
        }
    }
}
