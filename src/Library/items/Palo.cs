namespace RoleplayGame.Items
{
    /// <summary>
    /// Es una espada.
    /// </summary>
    public class Palo : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Palo";
        }
    }
}