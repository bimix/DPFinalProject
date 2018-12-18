using DPFinalProject.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.StrategyPattern.ConcreteStrategies
{
    class NothingStrategy : SurvivalStrategy
    {
        public string useStrategy()
        {
            return "You do nothing";
        }
    }
}
