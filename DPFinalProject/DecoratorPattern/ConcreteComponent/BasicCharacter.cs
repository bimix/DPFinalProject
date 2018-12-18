using DPFinalProject.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.ConcreteComponent
{

    public sealed class BasicCharacter : ICharacter
    {
        public int moral;
        public string description;
        public bool radar;
        public bool updateStatus;


        public bool UpdateStatus()
        {
            throw new NotImplementedException();
        }

        public bool RadarStatus()
        {
            throw new NotImplementedException();
        }
        public string Description()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }

        public int Moral()
        {
            throw new NotImplementedException();
        }
    }

}
