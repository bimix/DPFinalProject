using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.FactoryMethodPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.FactoryMethodPattern.Factory
{
    interface MakeEventDifficulty
    {
        Event getEvent();
        void add(ICharacter c);
        void notify();
    }
}
