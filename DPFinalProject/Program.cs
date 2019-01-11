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
            Character character = new BasicCharacter();
            int difficulty = 1;
            int level = 1;
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
            // Test
            //Event test = new FactoryMethodPattern.Product.ConcreteProducts.FindPetEvent();
            //character = test.getBuffedCharacter(character);
            // End
            eventMaker.add(character);
            Event someEvent = eventMaker.getEvent();
            if (character.getUpdateStatus())
            {
                Console.WriteLine("Choose a startegy:");
                Console.WriteLine("1.Build a shelter.");
                Console.WriteLine("2.Make some clothes to wear.");
                Console.WriteLine("3.Go find a new are to live in.");
                Console.WriteLine("Do nothing (type anything exept 1, 2 or 3)");
                SurvivalStrategy strategy;
                int strategyChoice = Console.Read();
                switch (strategyChoice)
                {
                    case 49:
                        strategy = new BuildingStrategy();
                        break;
                    case 50:
                        strategy = new DressingStrategy();
                        break;
                    case 51:
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
                else
                {
                    Console.WriteLine("New moral is " + character.getMoral());
                }
            }
            else
            {
                character = someEvent.getBuffedCharacter(character);
                Console.WriteLine(character.getDescription());
                Console.WriteLine("New moral is " + character.getMoral());
            }
            Console.ReadKey();
        }
    }
}
