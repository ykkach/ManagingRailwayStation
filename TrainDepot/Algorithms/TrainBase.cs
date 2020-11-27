using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BL
{
    public partial class Train : IComparable<Train>
    {
        public Train() : this(0)
        { }
        public Train(int number)
        {
            trainNumber = number;
        }
        public Train(int number, string[] stationNames, int[] kilometers, int[] times)
        {
            trainNumber = number;
            stations = new List<Station>(stationNames.Length);
            addStations(stationNames, kilometers, times);
        }
        public Train(Train train)
        {
            //copy fields
        }

    }
}