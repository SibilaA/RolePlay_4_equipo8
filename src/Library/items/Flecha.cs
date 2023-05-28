namespace RoleplayGame.Items
{
    /// <summary>
    /// Es una flecha.
    /// </summary>
    public class Flecha : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return "Flecha";
        }
    }
}