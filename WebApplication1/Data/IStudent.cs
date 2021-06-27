using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface IStudent
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Insert(Student student);
        void Update(int id, Student student);
        void Delete(int id);
    }
}
