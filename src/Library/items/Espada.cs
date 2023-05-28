namespace RoleplayGame.Items
{
    /// <summary>
    /// Es una espada.
    /// </summary>
    public class Espada : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Espada";
        }
    }
}