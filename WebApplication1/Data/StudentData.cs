using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentData : IStudent
    {
        private List<Student> listStudent;

        public StudentData()
        {
             listStudent = new List<Student> {
                new Student
                {
                    ID = 1,
                    FirstMidName ="MyLove",
                    LastName = "apapun",
                    EnrollmentDate = DateTime.Now
                },
                new Student
                {
                    ID = 2,
                    FirstMidName ="Kevin",
                    LastName = "Katsura",
                    EnrollmentDate = DateTime.Now
                }
            };
        }
        public IEnumerable<Student> GetAll()
        {
            return listStudent;
        }

        public Student GetById(int id)
        {
            var result = (from std in listStudent where std.ID == id select std).FirstOrDefault();
            return result;
        }

        public void Insert(Student student)
        {
            listStudent.Add(student);
        }

        public void Update(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
