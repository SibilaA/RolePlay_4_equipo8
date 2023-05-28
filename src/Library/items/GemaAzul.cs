namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema Azul para el guante.
    /// </summary>
    public class GemaAzul: IGemas
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 12;
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
                return 80;
            }
        }

    }
}