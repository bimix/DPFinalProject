﻿using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject.FactoryMethodPattern.Product
{
    interface GoodEvent: Event
    {
        BuffedCharacter getBuffedCharacter(ICharacter c);
    }
}
