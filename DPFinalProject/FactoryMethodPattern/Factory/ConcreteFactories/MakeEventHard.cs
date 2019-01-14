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
        private string level;
        private List<Character> observersList = new List<Character>();
        Random rnd = new Random();

        public void removeAll()
        {
            observersList.Clear();
        }

        public MakeEventHard(string level)
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

            Event returnedEvent = null;

            int div = Int32.Parse(level);

            if (goodEventsCount == 0 && badEventsCount == 0)
            {
                int ev = rnd.Next(1, 6);
                switch (ev)
                {
                    case 1:
                        returnedEvent = new FindPetEvent();
                        break;
                    case 2:
                        returnedEvent = new SunnyDayEvent();
                        break;
                    case 3:
                        returnedEvent = new ColdEvent();
                        break;
                    case 4:
                        returnedEvent = new StormEvent();
                        break;
                    case 5:
                        returnedEvent = new FallEvent();
                        break;
                    case 6:
                        returnedEvent = new FindSupplyEvent();
                        break;
                }
                return returnedEvent;
            }
            else
            {
                if (goodEventsCount < (div * 30 / 100))
                {
                    int ev;

                    if (observersList[0].getRadarStatus())
                    {
                        ev = rnd.Next(2, 3);
                    }
                    else
                    {
                        ev = rnd.Next(1, 3);
                    }

                    switch (ev)
                    {
                        case 1:
                            returnedEvent = new FindPetEvent();
                            break;
                        case 2:
                            returnedEvent = new SunnyDayEvent();
                            break;
                        case 3:
                            returnedEvent = new FindSupplyEvent();
                            break;
                    }
                    goodEventsCount++;
                    return returnedEvent;
                }
                else
                {
                    int ev = rnd.Next(1, 3);
                    switch (ev)
                    {
                        case 1:
                            returnedEvent = new ColdEvent();
                            break;
                        case 2:
                            returnedEvent = new StormEvent();
                            break;
                        case 3:
                            returnedEvent = new FallEvent();
                            break;
                    }
                    badEventsCount++;
                    return returnedEvent;
                }
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
