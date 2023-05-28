namespace RoleplayGame.Items
{
    /// <summary>
    /// Es un arco.
    /// </summary>
    public class Arco : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "Arco";
        }
    }
}