using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13_11_efstep.Exceptions
{
    internal class StudentNotFoundException:Exception
    {
        public StudentNotFoundException() : base("Student not found")
        {

        }
    }
}
