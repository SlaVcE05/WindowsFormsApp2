using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Bus
    {
        String registation { get; set; }
        String name { get; set; }
        bool isLocal { get; set; }
        public List<Line> lines { get; }

        public Bus(String reg, string name, bool isLocal)
        {
            this.registation = reg;
            this.name = name;
            this.isLocal = isLocal;
            lines = new List<Line>();
        }

        public void addLine(Line line) 
        {
            lines.Add(line);
        }

        public override string ToString()
        {
            return $"{name} - {registation} - {(isLocal?"L":"M")}";
        }

    }
}
