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
        private Character character;
        public ColdCharacter(Character character)
        {
            this.character = character;
        }

        public string getDescription()
        {
            return "You are now cold";
        }

        public int getMoral()
        {
            return character.getMoral() - 10;
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
