namespace RoleplayGame.Items
{
    /// <summary>
    /// Es un Baston Magico.
    /// </summary>
    public class BastonMagico : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 25;
            }
        }

        public override string ToString()
        {
            return "BastonMagico";
        }
    }
}