using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDepot
{
    class TrainList
    {
        private static readonly TrainList instance = new TrainList();
        public LinkedList<Train> trainList { get; private set; }

        public TrainList()
        {
            trainList = new LinkedList<Train>();
            //initialize and fill with Trains
            //read data from file and parse
        }

        public static TrainList getinstance()
        {
            return instance;
        }
    }
}


//class OS
//{
//    private static OS instance;

//    public string Name { get; private set; }
//    private static object syncRoot = new Object();

//    protected OS(string name)
//    {
//        this.Name = name;
//    }

//    public static OS getInstance(string name)
//    {
//        if (instance == null)
//        {
//            lock (syncRoot)
//            {
//                if (instance == null)
//                    instance = new OS(name);
//            }
//        }
//        return instance;
//    }
//}