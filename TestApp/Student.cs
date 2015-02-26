using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Student
    {
        public string Name { set; get; }
        public string RegNo { set; get; }
        public string Email { set; get; }

        public string GetInformation()
        {
            return Name;
        }
    }
}
