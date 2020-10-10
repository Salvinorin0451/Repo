using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass01
{
    partial class Employee
    {
        private string a;
        private string b;

        public Employee()
        {
               
        }

        public Employee(string a = "", string b = "")
        {
            this.a = a;
            this.b = b;
        }
    }
}
