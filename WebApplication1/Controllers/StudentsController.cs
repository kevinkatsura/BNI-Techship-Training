using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudent _student;
        public StudentsController(IStudent student)
        {
            _student = student;
        }
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _student.GetAll();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            /*var result = listStudent.Where(s => s.ID == id).FirstOrDefault();*/
            return _student.GetById(id);
        }
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            /*var result = listStudent.Where(s => s.ID == id).FirstOrDefault();*/
            _student.Insert(student);        }
    }
}
