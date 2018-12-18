using DPFinalProject.DecoratorPattern.Component;
using DPFinalProject.DecoratorPattern.ConcreteComponent;
using DPFinalProject.DecoratorPattern.ConcreteDecorator;
using DPFinalProject.DecoratorPattern.Decorator;
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
<<<<<<< HEAD
            BuffedCharacter decorator = new DecoratorPattern.ConcreteDecorator.ColdCharacter(character);
=======
            BuffedCharacter decorator = new DecoratorPattern.ConcreteDecorator.HappyCharacter(character);
>>>>>>> 3416651c95f4981d46d42b867ac1e40843168c87
            Console.WriteLine(string.Format("Moral :{0}", decorator.Moral));

            Console.ReadLine();
        }
    }
}
