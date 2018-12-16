using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.ConcreteDecorator
{
    public class InjuredCharacter : BuffedCharacter
    {

        public InjuredCharacter(ICharacter character) : base(character)
        {
        }


    }
}
