using DPFinalProject.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.StrategyPattern.ConcreteStrategies
{
    class ExploringStrategy : SurvivalStrategy
    {
        public void useStrategy()
        {
            Console.WriteLine("You go and find a new place to stay while the event is happening so it doesn't affect you.");
        }
    }
}
