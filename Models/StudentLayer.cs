using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEMPTY.Models
{
    public class StudentLayer
    {
        public Student GetDetails(int sid)
        {
            Student student = new Student()
            {
                Id = sid,
                Name = "John"
            };
            return student;
        }
    }
}