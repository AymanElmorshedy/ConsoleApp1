using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        private int id;
        private string name;
        private Permissions security_Level;
        private int salary;
        private Gender gender;
        private int day;
        private int month;
        private int year;

        public Employee(int id, string name, Permissions security_Level, int salary, Gender gender, int day, int month, int year)
        {
            this.id = id;
            this.name = name;
            this.security_Level = security_Level;
            this.salary = salary;
            this.gender = gender;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"Id:{id}\nName:{name}\nSecurity_level:{security_Level}\nSalary:{salary:c}\nGender{gender}\nDay:{day}\nMounth:{month}\nYear:{year}";
        }
        public int Id
        {
            get { return id ; }
            set { id = value ; }
        }
        public string Name
        {
            get{ return name ; }
            set { name = value ; }
        }
        public Permissions Security_Level
        {
            get { return security_Level ; }
            set { security_Level = value ; }
        }
        public int Salary
        {
            get { return salary ; }
            set { salary = value ; }
        }
        public Gender Gender
        {
            get { return gender ; }
            set { gender = value ; }
        }
        public int Day
        {
            get { return day ;}
            set { day = value ; }
        }
        public int Month
        {
            get { return month ;}
            set { month = value ; }
        }
        public int Year
        {
            get { return year ;}
            set { year = value ; }

        }

    }
    public enum Gender
    {
        Male,Female
    }
    [Flags]
    public enum Permissions
    {
        guest = 1, developer = 2, secretary = 4, dba = 8
    }


}
