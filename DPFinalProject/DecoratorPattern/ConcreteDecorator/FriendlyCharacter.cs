using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.ConcreteDecorator
{
    class FriendlyCharacter : BuffedCharacter
    {
        private ICharacter character;

        public FriendlyCharacter(ICharacter character)
        {
            this.character = character;
        }

        public string getDescription()
        {
            return "You have found a pet.";
        }

        public int getMoral()
        {
            return character.getMoral() + 10;
        }

        public bool getRadarStatus()
        {
            return true;
        }

        public bool getUpdateStatus()
        {
            return character.getUpdateStatus();
        }

        public void update()
        {
            character.update();
        }
    }
}
