using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.ConcreteDecorator
{
    class AbundentCharacter : BuffedCharacter
    {
        private Character character;
        public AbundentCharacter(Character character)
        {
            this.character = character;
        }

        public string getDescription()
        {
            return "You have no worries for the next few days.";
        }

        public int getMoral()
        {
            return character.getMoral() + 15;
        }

        public bool getRadarStatus()
        {
            return character.getRadarStatus();
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
