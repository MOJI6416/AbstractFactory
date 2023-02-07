using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarLevel2 : Car
    {
        public CarLevel2()
        {
            speed = 20;
            color = "green";
            mark = "BMW";
        }
    }

    public class RoadLevel2 : Road
    {
        public RoadLevel2()
        {
            length = 20;
            width = 3;
            barriers = 8;
        }
    }

    public class Level2 : AbstractLevel
    {
        public override Car createCar()
        {
            return new CarLevel2();
        }
        public override Road createRoad()
        {
            return new RoadLevel2();
        }
        public override Finish createFinish()
        {
            return new Finish(1.5f, 18.5f);
        }
        public override void Play()
        {
            c = createCar();
            r = createRoad();
            f = createFinish();
        }
    }
}
