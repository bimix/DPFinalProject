using DPFinalProject.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.StrategyPattern.ConcreteStrategies
{
    public class DressingStrategy : SurvivalStrategy
    {
        public string useStrategy()
        {
            return "You make clothes from the resources found and the event passes without affecting you.";
        }
    }
}
