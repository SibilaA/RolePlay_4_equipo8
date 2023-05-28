namespace RoleplayGame.Items
{
    /// <summary>
    /// Clase compuesta que representa un Arco junto con una Flecha.
    /// </summary>
    public class ArcoConFlecha : IAttackItem
    {
        private Arco arco;
        private Flecha flecha;

        /// <summary>
        /// Constructor de la clase ArcoConFlecha.
        /// </summary>
        public ArcoConFlecha()
        {
            arco = new Arco();
            flecha = new Flecha();
        }

        /// <summary>
        /// El poder de ataque del ArcoConFlecha, que es la suma del poder de ataque del Arco y la Flecha.
        /// </summary>
        public int AttackPower
        {
            get
            {
                return arco.AttackPower + flecha.AttackPower;
            }
        }

        /// <summary>
        /// Representación en cadena del ArcoConFlecha.
        /// </summary>
        /// <returns>La representación en cadena del ArcoConFlecha.</returns>
        public override string ToString()
        {
            return $"Arco con Flecha";
        }
    }
}