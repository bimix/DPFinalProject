using DPFinalProject.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.FactoryMethodPattern.Product
{
    interface BadEvent: Event
    {
        ICharacter getBuffedCharacter(ICharacter c);
    }
}
