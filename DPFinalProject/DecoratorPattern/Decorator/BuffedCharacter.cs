using DPFinalProject.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.Decorator
{
    public abstract class BuffedCharacter : ICharacter
    {

        private ICharacter character;

       

        public int Moral => throw new NotImplementedException();

        public bool UpdateStatus => throw new NotImplementedException();

        public bool RadarStatus => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

}
