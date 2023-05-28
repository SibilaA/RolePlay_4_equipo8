using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Dwarf
    /// </summary>
    public class Dwarves : Character
    {
        public Dwarves(string name)
            : base(name)
        {
            this.Health = 110;
            this.AddItem(new Espada());
        }
    }
}