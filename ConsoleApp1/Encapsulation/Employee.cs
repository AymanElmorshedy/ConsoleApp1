using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
       public int id;
       private string? name;
       private decimal salary;

        #endregion

        #region Constructor
        public Employee(int id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            Salary = salary;
        }
        #endregion
        #region Methods 
        public override string ToString()
        {
            return $"id: {id}\nName:{name}\nSalary:{salary:c}";
        }
        #endregion
        #region Getter-setter
        public string? GetName()
        {
            return name ;
        }

        public void SetName(string? Name)
        {
            name = Name?.Length > 5 ? Name.Substring(0, 5) : Name;
        }
        #endregion
        #region Propierty
        public decimal Salary
        {
            get { return salary;}
            set { salary = value>5000?value=5000:value; }
        }
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        public int Age { get; set; }

        //private decimal deduction;//Drived attribute was in Erd
        public decimal Deduction//read only proberity
        {
            get { return Salary * 0.2m; }
        }
        #endregion
    }
}
