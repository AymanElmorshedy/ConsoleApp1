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

            #endregion
            #endregion
            #endregion
        }
    }
}
    