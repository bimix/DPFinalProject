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
            //return new FindPetEvent();

            if (observersList[0].getRadarStatus())
            {
                notify();
            }

            Random rnd = new Random();

            int ev = rnd.Next(1, 4);
            Console.WriteLine(ev);

            Event returnedEvent = null;

            int div = Int32.Parse(level);


            if (goodEventsCount < (div / 2))//condition
            {
                //switch with good events

                switch (ev)
                {

                    case 1:
                        returnedEvent = new FindPetEvent();
                        break;
                    case 2:
                        returnedEvent = new SunnyDayEvent();
                        break;
                }

                return returnedEvent;

            }
            else
            {
                //switch with bad event

                switch (ev)
                {
                    case 3:
                        returnedEvent = new ColdEvent();
                        break;
                    case 4:
                        returnedEvent = new StormEvent();
                        break;
                }
                return returnedEvent;

            }



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
