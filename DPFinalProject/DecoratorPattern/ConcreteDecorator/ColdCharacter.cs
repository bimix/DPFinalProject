using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.ConcreteDecorator
{
    public class ColdCharacter : BuffedCharacter
    {

        public ICharacter character;

        public new bool UpdateStatus()
        {
            throw new NotImplementedException();
        }

        public new bool RadarStatus()
        {
            throw new NotImplementedException();
        }
        public new string Description()
        {
            throw new NotImplementedException();
        }
        public new void Update()
        {
            throw new NotImplementedException();
        }

        public new int Moral()
        {
            throw new NotImplementedException();
        }

    }
}
