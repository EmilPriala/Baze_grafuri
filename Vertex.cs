using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baze_grafuri
{
    public class Vertex
    {
        public int value;
        public int X, Y;
        public Vertex(int v) 
        {
            value = v;
        }
        public Vertex(int value, int x, int y) : this(value)
        {
            X = x;
            Y = y;
        }
    }
}
