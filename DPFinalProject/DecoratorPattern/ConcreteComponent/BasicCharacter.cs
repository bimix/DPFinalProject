using DPFinalProject.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.ConcreteComponent
{

    public sealed class BasicCharacter : Character
    {
        private int moral = 100;
        private string description = "You are basic";
        private bool radar = false;
        private bool updateStatus = false;

        public string getDescription()
        {
            return description;
        }

        public int getMoral()
        {
            return moral;
        }

        public bool getRadarStatus()
        {
            return radar;
        }

        public bool getUpdateStatus()
        {
            return updateStatus;
        }

        public void update()
        {
            updateStatus = true;
        }
    }

}
