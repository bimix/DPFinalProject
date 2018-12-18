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
    class MakeEventNormal : MakeEventDifficulty
    {
        private int goodEventsCount;
        private int badEventsCount;
        private int level;
        private List<ICharacter> observersList;
        public void add(ICharacter c)
        {
            observersList.Add(c);
        }

        public Event getEvent()
        {
            // complex logic for returning new event depending on the number of bad and good events it returned
            return new ColdEvent();
        }

        public void notify()
        {
            foreach (ICharacter character in observersList)
            {
                character.update();
            };
        }
    }
}
