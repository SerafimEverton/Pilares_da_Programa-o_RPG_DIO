using System;
using DesafioDIO.src.Entities;

namespace dotnet___DesafioDIO{

    class Program{

        static void Main(string[] args)
        {
           Knight knight = new Knight("Robert", 43, "Duas Espadas", 670, 83);
           WhiteWizard whitewizard = new WhiteWizard("Jennica", 44, "White Wizard", 540, 74);
           BlackWizard blackwizard = new BlackWizard("Topapa", 28, "Black Wizard", 720, 83);
           Ninja ninja = new Ninja("Wedge", 32, "Ninja", 899, 96);

            Console.WriteLine("Deu certo");
            Console.WriteLine("------------------");
            
            Console.WriteLine(knight);
            Console.WriteLine(knight.Attack(10));
            Console.WriteLine(knight.Attack(3));
            Console.WriteLine(knight.AddItems(knight.ExperienceLevel));
            Console.WriteLine("Seu poder é de " + knight.PowerLevel + " e seu nível de vida é de " + knight.LevelLife + "%");
            Console.WriteLine("------------------");


            Console.WriteLine(whitewizard);
            Console.WriteLine(whitewizard.Attack());
            Console.WriteLine(whitewizard.Attack(13));
            Console.WriteLine(whitewizard.Attack(2));
            Console.WriteLine(whitewizard.AddItems(whitewizard.ExperienceLevel));
            Console.WriteLine("Seu poder é de " + whitewizard.PowerLevel + " e seu nível de vida é de " + whitewizard.LevelLife + "%");
            Console.WriteLine("------------------");

            Console.WriteLine(blackwizard);
            Console.WriteLine(blackwizard.Attack());
            Console.WriteLine(blackwizard.Attack(11));
            Console.WriteLine(blackwizard.Attack(5));
            Console.WriteLine(blackwizard.AddItems(blackwizard.ExperienceLevel));
            Console.WriteLine("Seu poder é de " + blackwizard.PowerLevel + " e seu nível de vida é de " + blackwizard.LevelLife + "%");
            Console.WriteLine("------------------");

            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ninja.Attack(16));
            Console.WriteLine(ninja.Attack(1));
            Console.WriteLine(ninja.AddItems(ninja.ExperienceLevel));
            Console.WriteLine("Seu poder é de " + ninja.PowerLevel + " e seu nível de vida é de " + ninja.LevelLife + "%");

        }
    }
}