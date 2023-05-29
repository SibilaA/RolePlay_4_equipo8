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
            //Primer Encuentro
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

            //Segundo Encuentro
            Character p3 = new Wizard("Gandalf");
            p3.AddItem(new BastonMagico());
            p3.AddItem(new Magic());

            Character p4 = new Troll("Olog-Hai");

            ConsoleReporter console2 = new ConsoleReporter();
            AttackEncounter e2 = new AttackEncounter(p3, p4);
            e2.Reporter = console2;
            e2.DoEncounter();
            Character g2 = e2.GetGanador();
            Console.WriteLine($"El ganador es {g2.Name}");

            //Final

            ConsoleReporter console3 = new ConsoleReporter();
            AttackEncounter e3 = new AttackEncounter(g1, g2);
            e3.Reporter = console3;
            e3.DoEncounter();
            Character g3 = e3.GetGanador();
            Console.WriteLine($"El campeon de la Tierra media es {g3.Name}");

        }
    }
}
