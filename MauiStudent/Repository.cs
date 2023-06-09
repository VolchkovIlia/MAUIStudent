using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStudent
{
    public class Repository
    {
        private List<Student> students = new List<Student>();

        public Repository()
        {
            // Заполнение коллекции студентов по умолчанию
            students.Add(new Student("Иван", "Иванов", 18));
            students.Add(new Student("Петр", "Петров", 20));
            students.Add(new Student("Мария", "Сидорова", 19));
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }

}
