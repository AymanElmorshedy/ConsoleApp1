using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Person
    {
        #region Proberites
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion
        #region Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;  
        }
        #endregion



    }
}
