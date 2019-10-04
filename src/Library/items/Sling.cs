namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Sling : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 40;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>

        public override string ToString()
        {
            return "Sling";
        }
    }
}