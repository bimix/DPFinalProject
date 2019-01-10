using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.Component
{
    public interface Character
    {
        bool getUpdateStatus();
        bool getRadarStatus();
        string getDescription();
        void update();
        int getMoral();
    }
}
