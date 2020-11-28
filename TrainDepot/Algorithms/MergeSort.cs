using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class MergeSort
    {

        public List<Train> sortByFStation(List<Train> unsorted)
        {
            if (unsorted.Count < 2)
                return unsorted;

            List<Train> left = new List<Train>();
            List<Train> right = new List<Train>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = sortBySpeed(left);
            right = sortBySpeed(right);
            return Merge(left, right, 1);
        }

        public List<Train> sortBySpeed(List<Train> unsorted)
        {
            if (unsorted.Count < 2)
                return unsorted;

            List<Train> left = new List<Train>();
            List<Train> right = new List<Train>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = sortBySpeed(left);
            right = sortBySpeed(right);
            return Merge(left, right, 0);
        }
        private List<Train> Merge(List<Train> left, List<Train> right, int flag)
        {
            TrainComparator trainComp = new TrainComparator();
            Comparer<Train> bc = (Comparer<Train>)trainComp;
            List<Train> result = new List<Train>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (flag == 0)
                    {
                        if (trainComp.Compare(left.First(), right.First()) < 0)
                        //if (left.First() <= right.First()) for string(stationName)
                        {
                            result.Add(left.First());
                            left.Remove(left.First());
                        }
                        else
                        {
                            result.Add(right.First());
                            right.Remove(right.First());
                        }
                    }
                    else
                    {
                        //if (trainComp.Compare(left.First(), right.First()) < 0) for double(average speed)
                        if (left.First() <= right.First())
                        {
                            result.Add(left.First());
                            left.Remove(left.First());
                        }
                        else
                        {
                            result.Add(right.First());
                            right.Remove(right.First());
                        }
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }


}
