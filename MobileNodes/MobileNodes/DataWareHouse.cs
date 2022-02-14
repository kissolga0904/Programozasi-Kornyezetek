using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNodes
{
    class DataWareHouse
    {
        public Location Location { get; set; }
        private static DataWareHouse dataWareHouse;
        private DataWareHouse(Location location)
        {       
            this.Location = (Location)location.Clone();
        }
        public static DataWareHouse GetDataWareHouse(Location location)
        {
            //megnézzük, hogy a statikus példányunk null-e
            if (dataWareHouse == null)
            {
                dataWareHouse = new DataWareHouse(location);
            }
            return dataWareHouse;
        }
    }
}
