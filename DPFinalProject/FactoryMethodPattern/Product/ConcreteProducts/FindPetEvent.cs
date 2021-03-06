﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.ConcreteDecorator;
using DPFinalProject.DecoratorPattern.Decorator;

namespace DPFinalProject.FactoryMethodPattern.Product.ConcreteProducts
{
    class FindPetEvent : GoodEvent
    {
        public BuffedCharacter getBuffedCharacter(Character c)
        {
            Console.WriteLine("Exploring through the jungle, you find a friendly monkey. It will be your pet from now.");
            return new FriendlyCharacter(c);
        }
    }
}
