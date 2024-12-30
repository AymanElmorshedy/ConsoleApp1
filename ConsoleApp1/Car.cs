using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
      

        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        public Car(int id, string model):this(id, model,240)
        {
            //Id = id;
            //Model = model;
            //Speed = 240;
        }

        public Car(int id):this(id,"Tesla",300)
        {
            //Id = id;
            //Model = "tesla";
            //Speed = 300;
        }

        public override string ToString()
        {
            return $"Id:{Id}\nModel:{Model}\nSpeed:{Speed}";
        }

    }
}
