using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using DPFinalProject.DecoratorPattern.ConcreteDecorator;

namespace DPFinalProject.FactoryMethodPattern.Product.ConcreteProducts
{
    class FindSupplyEvent: GoodEvent
    {
        public BuffedCharacter getBuffedCharacter(Character c)
        {
            Console.WriteLine("Durring your walk, you stumble upon a crate with supplies.");
            return new AbundentCharacter(c);
        }
    }
}
