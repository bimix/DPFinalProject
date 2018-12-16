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
        public BuffedCharacter(ICharacter Character)
        {
            character = Character;
        }
        public string Moral { get { return character.Moral; } }
    }

}
