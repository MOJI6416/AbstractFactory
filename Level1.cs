using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarLevel1 : Car
    {
        public CarLevel1()
        {
            speed = 10;
            color = "blue";
        }
    }

    public class RoadLevel1 : Road
    {
        public RoadLevel1()
        {
            length = 15;
            barriers = 5;
        }
    }
    public class Level1 : AbstractLevel
    {
        public override Car createCar()
        {
            return new CarLevel1();
        }
        public override Road createRoad()
        {
            return new RoadLevel1();
        }
        public override Finish createFinish()
        {
            return new Finish(0.5f, 10.0f);
        }
        public override void Play()
        {
            c = createCar();
            r = createRoad();
            f = createFinish();
        }
    }
}
