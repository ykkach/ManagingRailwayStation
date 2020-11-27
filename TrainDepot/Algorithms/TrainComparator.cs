using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TrainComparator : Comparer<Train>
    {
        public override int Compare(Train TrainA, Train TrainB)
        {
            return TrainA.CompareTo(TrainB);
        }
    }
}
