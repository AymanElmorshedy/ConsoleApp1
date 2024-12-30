using ConsoleApp1.Encapsulation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo-assignment part1
            #region Encapsulation
            //Employee employee = new Employee(1, "ali", 2500);//bassing by value,order
            ////Employee employee = new Employee(name: "Ali",id: 1,salary: 2500);//bassing by name

            //Console.WriteLine(employee);
            //////employee.id = 12;//false becuse using attribute direct
            //////Console.WriteLine(employee.id);
            ////employee.SetName("Amir");
            ////Console.WriteLine(employee.GetName());

            //employee.Salary = 4000;
            //Console.WriteLine(employee.Deduction); 
            #endregion

            #region PhoneBook
            //PhomeBook note = new PhomeBook(3);
            //note.AddPerson(0, "amany", 123);
            //note.AddPerson(1, "ali", 456);
            //note.AddPerson(2, "amr", 789);

            ////int number = note.Getphone("ali");
            ////Console.WriteLine(number==0?"not found":number);

            ////note["amany"] = 888;
            ////Console.WriteLine(note["amany"]);

            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //} 
            #endregion

            #region Class Car
            //Car car = new Car(1,"BMW",180);
            //Console.WriteLine(car);


            #endregion
            #endregion

            #region Assignment
            #region Part02
            #region Q1
            //Person[] person = new Person[3];
            //person[0]=new Person("ali",22);
            //person[1]=new Person("Ahmed",33);
            //person[2]=new Person("Ayman",18);

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.Write(person[i].Name);
            //    Console.WriteLine( person[i].Age);
            //}

            #endregion
            #region Q2
            //Person[] person = new Person[3];
            //int age1;
            //int age2;
            //int age3;
            //bool flag1;
            //bool flag2;
            //bool flag3;
            //Console.WriteLine("Entetr Name 1:");
            //string Name1=Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("please enter age1");
            //    flag1 = int.TryParse(Console.ReadLine(), out age1);
            //}while( !flag1 || !(age1>=18 && age1<=60));

            //Console.WriteLine("Entetr Name 2:");
            //string Name2 = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("please enter age2");
            //    flag2 = int.TryParse(Console.ReadLine(), out age2);
            //} while (!flag2 || !(age2 >= 18 && age2 <= 60));

            //Console.WriteLine("Entetr Name 3:");
            //string Name3 = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("please enter age3");
            //    flag3 = int.TryParse(Console.ReadLine(), out age3);
            //} while (!flag1 || !(age3 >= 18 && age3 <= 60));
            //person[0] = new Person(Name1,age1);
            //person[1] = new Person(Name2,age2);
            //person[2] = new Person(Name3,age3);
            //int Oldest = Math.Max(person[0].Age,Math.Max( person[1].Age, person[2].Age));
            //for (int i = 0; i < person.Length; i++)
            //{
            //    if (person[i].Age == Oldest)
            //    {
            //        Console.WriteLine($"{person[i].Name} , {person[i].Age}");
            //    }
            //}

            #endregion
            #endregion

            #region Part03
            #region Display Employee Data
            //Employee employee = new Employee(1, "anwar", Permissions.guest, 6000, Gender.Male, 1, 12, 2020);
            //Console.WriteLine(employee.ToString());
            #endregion
            #region Array of employees
            Employee[] employee = new Employee[3];
            employee[0] = new Employee(2, "Ali", Permissions.dba, 12000, Gender.Male, 2, 8, 2015);
            employee[1] = new Employee(3, "salma", Permissions.guest, 2000, Gender.Female, 12, 7, 2022);
            employee[2] = new Employee(4, "Salem", (Permissions)15, 20000, Gender.Male, 5, 11, 2013);
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine(employee[i].ToString());
                Console.WriteLine();
            } 
            #endregion
            #endregion
            #endregion
        }
    }
}
    