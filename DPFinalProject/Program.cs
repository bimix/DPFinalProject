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
            Console.WriteLine("Choose a difficulty:");
            Console.WriteLine("1.Hard; 2.Normal; 3.Easy");
            string difficulty = Console.ReadLine();
            Console.WriteLine("Choose a level:");
            string level = Console.ReadLine();
            MakeEventDifficulty eventMaker;
            switch (difficulty)
            {
                case "1":
                    eventMaker = new MakeEventHard(level);
                    break;
                case "2":
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
            int endAt = Int32.Parse(level);
            for(int i = 0; i < endAt; i++)
            {
                Console.ReadKey();
                Event someEvent = eventMaker.getEvent();
                if (character.getRadarStatus())
                {
                    someEvent.getBuffedCharacter(character);
                    Console.WriteLine("Choose a startegy:");
                    Console.WriteLine("1.Build a shelter.");
                    Console.WriteLine("2.Make some clothes to wear.");
                    Console.WriteLine("3.Go find a new are to live in.");
                    Console.WriteLine("Do nothing (type anything exept 1, 2 or 3)");
                    SurvivalStrategy strategy;
                    string strategyChoice = Console.ReadLine();
                    switch (strategyChoice)
                    {
                        case "1":
                            strategy = new BuildingStrategy();
                            break;
                        case "2":
                            strategy = new DressingStrategy();
                            break;
                        case "3":
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
            }
            
            Console.ReadKey();
        }
    }
}
