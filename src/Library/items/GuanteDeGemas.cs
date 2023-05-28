using System.Collections.Generic;
namespace RoleplayGame.Items

{
    /// <summary>
    /// Guante.
    /// </summary>
    public class GuanteDeGemas : IAttackItem, IDefenseItem
    {

        private List<IGemas> gemas = new List<IGemas>();

        public int AttackPower
        {
            get
            {
                int value = 20;
                foreach (IGemas gemas in this.gemas)
                {
                    value += gemas.AttackPower;
                }
                return value;
            }
        }

        public int DefensePower
        {
            get
            {
                int value = 2;
                foreach (IGemas gemas in this.gemas)
                {
                    value += gemas.DefensePower;
                }
                return value;
            }
        }

        public void AddGema (IGemas gemas)
        {
            this.gemas.Add(gemas);
        }

        public void RemoveGema (IGemas gemas)
        {
            this.gemas.Remove(gemas);
        }

        public override string ToString()
        {
            return "Guante de gemas";
        }


        
    }
}