using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.DecoratorPattern.Component
{
    public interface ICharacter
    {
        int Moral { get; }
        bool UpdateStatus { get; }
        bool RadarStatus { get; }
        string Description { get; }

        void Update();
    }
}
