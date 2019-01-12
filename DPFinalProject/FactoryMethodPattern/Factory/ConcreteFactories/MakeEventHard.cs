using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.FactoryMethodPattern.Product;
using DPFinalProject.FactoryMethodPattern.Product.ConcreteProducts;

namespace DPFinalProject.FactoryMethodPattern.Factory.ConcreteFactories
{
    class MakeEventHard : MakeEventDifficulty
    {
        private int goodEventsCount;
        private int badEventsCount;
        private int level;
        private List<Character> observersList = new List<Character>();

        public MakeEventHard(int level)
        {
            this.level = level;
        }

        public void add(Character c)
        {
            observersList.Add(c);
        }

        public Event getEvent()
        {
            if (observersList[0].getRadarStatus())
            {
                notify();
            }
            // complex logic for returning new event depending on the number of bad and good events it returned

            // return new ColdEvent();
            Random rnd = new Random();

            int ev = rnd.Next(1, 4);

            Event returnedEvent = new ColdEvent();

            switch (ev)
            {
                case 1:
                    returnedEvent = new ColdEvent();
                    break;
                case 2:
                    returnedEvent = new StormEvent();
                    break;
                case 3:
                    returnedEvent = new FindPetEvent();
                    break;
                case 4:
                    returnedEvent = new SunnyDayEvent();
                    break;
            }

            return returnedEvent;
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
