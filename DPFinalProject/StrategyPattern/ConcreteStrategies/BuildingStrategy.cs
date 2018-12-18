using DPFinalProject.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.StrategyPattern.ConcreteStrategies
{
    public class BuildingStrategy : SurvivalStrategy
    {
        public void useStrategy()
        {
            Console.WriteLine("You build a shelter and the event passes without affecting you.");
        }
    }
}
