using Lab9.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.DAL
{
    public class StudentRepository: IStudentRepository
    {
        private StudentEntities studentContext = null;

        public StudentRepository()
        {
            studentContext = new StudentEntities();
        }

        public Student Get(int id)
        {
            return studentContext.Students.Find(id);
        }

        public List<Student> GetAll()
        {
            return studentContext.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                studentContext.Students.Add(student);
                studentContext.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            var studentFind = this.Get(student.ID);
            if (studentFind != null)
            {
                studentFind.Name = student.Name;
                studentFind.Contact = student.Contact;
                studentFind.Age = student.Age;
                studentFind.Address = student.Address;
                studentContext.SaveChanges();
            }
        }

        public void RemoveStudent(int id)
        {
            var studObj = studentContext.Students.Find(id);
            if (studObj != null)
            {
                studentContext.Students.Remove(studObj);
                studentContext.SaveChanges();
            }
        }
    }
}
