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
        public string Moral
        {
            get { return "I am sick"; }
        }
       
    }

}
