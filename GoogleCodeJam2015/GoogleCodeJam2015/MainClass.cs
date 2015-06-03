using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCodeJam2015
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //new qualificationRound.standingOvation.StandingOvation().Execute();
            //new qualificationRound.infiniteHouseOfPancakes.InfiniteHouseOfPancakes().Execute();
            new qualificationRound.dijkstra.Dijkstra().Execute();
            Console.ReadLine();
        }
    }
}
