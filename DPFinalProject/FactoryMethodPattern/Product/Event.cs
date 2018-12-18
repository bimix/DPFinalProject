using DPFinalProject.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.FactoryMethodPattern.Product
{
    public interface Event
    {
        ICharacter getBuffedCharacter(ICharacter c);
    }
}
