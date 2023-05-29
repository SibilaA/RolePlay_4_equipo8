using System.Collections.Generic;
using System;
namespace RoleplayGame.Items
{
    /// <summary>
    /// Guante.
    /// </summary>
    public class RandomObject : IItem
    {

        private List<IItem> items = new List<IItem>{new Arco() , new ArcoConFlecha(), new BastonMagico(), new Coraza(), new Espada(), new GuanteDeGemas(), new Palo(), new Robes()};

        public IItem PickObject ()
        {
            Random random = new Random();
            int ir = random.Next(items.Count);
            IItem RO = items[ir];
            return RO;
        }

        public void AddObject (IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveObject (IItem item)
        {
            this.items.Remove(item);
        }

        public override string ToString()
        {
            return "Objeto al azar";
        }


        
    }
}