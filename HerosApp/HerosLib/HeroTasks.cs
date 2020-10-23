using System;
using System.Threading.Tasks;

namespace HerosLib
{
    public delegate void HeroDel();

    public class HeroTasks : IHeroOperations, IHeroSuperPowers
    {
        string path = @"C:\Revature_Workspace\PanebiancoJames-Code\HerosApp\SuperPowers.txt";
        public async void DoWork()
        {
            Console.WriteLine("Work Started.....");
            await Task.Run(new Action(GetPowers));
            Console.WriteLine("Saving humanity is my work");
            Console.WriteLine("Work Finished");
        }

        public void ManageLife()
        {
            Console.WriteLine("I have a cranky partner to manage");
        }
   
        public void GetPowers()
        {
            Console.WriteLine("Getting Powers");
            System.Threading.Thread.Sleep(6000);
            string superPower = System.IO.File.ReadAllText(path);
            Console.WriteLine($"Power Obtained {superPower}");
        }
    }
}