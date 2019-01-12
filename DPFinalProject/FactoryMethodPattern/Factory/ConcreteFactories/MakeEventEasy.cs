﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.FactoryMethodPattern.Product;
using DPFinalProject.FactoryMethodPattern.Product.ConcreteProducts;

namespace DPFinalProject.FactoryMethodPattern.Factory.ConcreteFactories
{
    class MakeEventEasy : MakeEventDifficulty
    {
        private int goodEventsCount;
        private int badEventsCount;
        private string level;
        private List<Character> observersList = new List<Character>();

        public MakeEventEasy(string level)
        {
            this.level = level;
        }

        public void add(Character c)
        {
            observersList.Add(c);
        }

        public Event getEvent()
        {
            // complex logic for returning new event depending on the number of bad and good events it returned
            return new FindPetEvent();
        }

        public void notify()
        {
            foreach (Character character in observersList)
            {
                character.update();
            };
        }
    }
}
