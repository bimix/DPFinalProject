using DPFinalProject.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.Decorator
{
    public interface BuffedCharacter : ICharacter
    {
        bool getUpdateStatus();
        bool getRadarStatus();
        string getDescription();
        void update();
        int getMoral();
    }

}
