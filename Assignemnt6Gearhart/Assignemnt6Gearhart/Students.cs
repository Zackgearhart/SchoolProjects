using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt6Gearhart
{
    public class Students
    {
        List<Student> studentList = new List<Student>();

        public List<Student> GetStudents()
        {
            studentList = StudentDA.GetStudents();
            return studentList;
        }
    }
}
