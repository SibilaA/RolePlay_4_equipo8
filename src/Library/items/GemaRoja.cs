namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema para el guante.
    /// </summary>
    public class GemaRoja: IGemas
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
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
                return 50;
            }
        }

    }
}