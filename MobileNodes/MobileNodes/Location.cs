using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNodes
{
    class Location : ICloneable
    {
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public Location(float longitude, float latitude)
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
