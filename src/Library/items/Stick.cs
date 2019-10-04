namespace RoleplayGame.Items
{
    /// <summary>
    /// Stick. Permite picar en el ojo al oponente.
    /// </summary>
    public class Stick : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 45;
            }
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}