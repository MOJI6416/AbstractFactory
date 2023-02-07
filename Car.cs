using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Car
    {
        public int speed;
        public string color;
        public string mark;

        public Car()
        {
            speed = 1;
            color = "red";
            mark = "Mercedes";

        }
        public Car(int s, string c, string m)
        {
            speed = s;
            color = c;
            mark = m;
        }
    }
}
