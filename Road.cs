using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Road
    {
        public int length;
        public int width;
        public int barriers;

        public Road()
        {
            length = 10;
            width = 2;
            barriers = 3;

        }
        public Road(int l, int w, int b)
        {
            length = l;
            width = w;
            barriers = b;
        }
    }
}
