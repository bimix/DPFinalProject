using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.ObserverPattern
{
    public interface Event
    {
        public ICharacter BuffedCharacter(Character c)
        {
            throw new NotImplementedException();
        }
    }
}
