using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baze_grafuri
{
    public  class Edge
    {
        public Vertex begin, end;

        public Edge(Vertex begin, Vertex end) 
        {
            this.begin = begin;
            this.end = end;
        }
    }
}
