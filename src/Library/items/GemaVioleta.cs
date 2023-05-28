namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class GemaVioleta: IGemas
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 76;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 45;
            }
        }

    }
}