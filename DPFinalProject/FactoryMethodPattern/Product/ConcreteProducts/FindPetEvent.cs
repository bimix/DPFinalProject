using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.ConcreteDecorator;

namespace DPFinalProject.FactoryMethodPattern.Product.ConcreteProducts
{
    class FindPetEvent : GoodEvent
    {
        public ICharacter getBuffedCharacter(ICharacter c)
        {
            return new FriendlyCharacter(c);
        }
    }
}
