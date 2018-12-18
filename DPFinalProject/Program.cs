using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.ConcreteComponent;
using DPFinalProject.DecoratorPattern.ConcreteDecorator;
using DPFinalProject.DecoratorPattern.Decorator;
using DPFinalProject.FactoryMethodPattern.Factory;
using DPFinalProject.FactoryMethodPattern.Factory.ConcreteFactories;
using DPFinalProject.FactoryMethodPattern.Product;
using DPFinalProject.StrategyPattern.ConcreteStrategies;
using DPFinalProject.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacter character = new BasicCharacter();
            int difficulty = Console.Read();
            int level = Console.Read();
            MakeEventDifficulty eventMaker;
            switch (difficulty)
            {
                case 1:
                    eventMaker = new MakeEventHard(level);
                    break;
                case 2:
                    eventMaker = new MakeEventNormal(level);
                    break;
                default:
                    eventMaker = new MakeEventEasy(level);
                    break;
            }

            eventMaker.add(character);

            Event someEvent = eventMaker.getEvent();

            if (character.getUpdateStatus())
            {
                SurvivalStrategy strategy;
                int strategyChoice = Console.Read();
                switch (strategyChoice)
                {
                    case 1:
                        strategy = new BuildingStrategy();
                        break;
                    case 2:
                        strategy = new DressingStrategy();
                        break;
                    case 3:
                        strategy = new ExploringStrategy();
                        break;
                    default:
                        strategy = new NothingStrategy();
                        break;
                }

                string strategyDescription = strategy.useStrategy();

                Console.WriteLine(strategyDescription);

                if (strategyDescription == "You do nothing")
                {
                    character = someEvent.getBuffedCharacter(character);
                    Console.WriteLine(character.getDescription());
                    Console.WriteLine("New moral is " + character.getMoral());
                }
            }
            else
            {
                character = someEvent.getBuffedCharacter(character);
                Console.WriteLine(character.getDescription());
                Console.WriteLine("New moral is " + character.getMoral());
            }
        }
    }
}
