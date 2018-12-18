using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.ConcreteDecorator;
using DPFinalProject.DecoratorPattern.Decorator;

namespace DPFinalProject.FactoryMethodPattern.Product.ConcreteProducts
{
    class ColdEvent : BadEvent
    {
        public BuffedCharacter getBuffedCharacter(ICharacter c)
        {
            return new ColdCharacter(c);
        }
    }
}
