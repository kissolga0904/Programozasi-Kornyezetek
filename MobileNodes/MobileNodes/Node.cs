using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNodes
{
    enum RangeType{SMALL, MEDIUM, LARGE}
    class Node
    {
        public Location location { get; set; }
        public RangeType RangeType { get; set; }
        public float Range { get; set; }
    }
}
