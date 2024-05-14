using Lab9.DAL;
using Lab9.Model;
using Lab9.ViewModel;

namespace TestProject1
{
    public class UnitTest1
    {
        class StudentRepositoryFake : IStudentRepository
        {
            public void AddStudent(Student student)
            {
                throw new NotImplementedException();
            }

            public Student Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Student> GetAll()
            {
                return new List<Student> { new Student() { Name = "Kowal" }, new Student() { Name = "Nowak" } }; 
            }

            public void RemoveStudent(int id)
            {
                throw new NotImplementedException();
            }

            public void UpdateStudent(Student student)
            {
                throw new NotImplementedException();
            }
        }
        [Fact]
        public void Test1()
        {

            var studVM = new StudentViewModel(new StudentRepositoryFake());
            studVM.GetAll();

            Assert.Equal(2,studVM.StudentRecord.StudentRecords.Count());

        }
    }
}