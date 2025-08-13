using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    internal class Student
    {
        public int Id { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Dep_Id { get; set; }
    }
}
