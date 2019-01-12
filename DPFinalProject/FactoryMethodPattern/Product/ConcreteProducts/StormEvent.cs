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
    class StormEvent : BadEvent
    {
        public BuffedCharacter getBuffedCharacter(Character c)
        {
            Console.WriteLine("The storm is coming and it is realy scary.");
            return new WetCharacter(c);
        }
    }
}
