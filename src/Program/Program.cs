using RoleplayGame.Scenarios;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IScenario scenario = new ConsoleScenario();
            scenario.Setup();
            scenario.Run();
            */

            Character p1 = new Elf("Link");
            GuanteDeGemas guante1 = new GuanteDeGemas();
            guante1.AddGema(new GemaRosa());
            p1.AddItem(guante1);

            Character p2 = new Dwarves("Ganon");
            p2.AddItem(new Espada());

            ConsoleReporter console1 = new ConsoleReporter();
            AttackEncounter e1 = new AttackEncounter(p1, p2);
            e1.Reporter = console1;
            e1.DoEncounter();
            Character g1 = e1.GetGanador();
            Console.WriteLine($"El ganador es {g1.Name}");

        }
    }
}
