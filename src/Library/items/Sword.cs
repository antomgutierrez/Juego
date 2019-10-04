namespace RoleplayGame.Items
{
    /// <summary>
    /// Sword. Permite atacar.
    /// </summary>
    public class Sword : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 35;
            }
        }

        public override string ToString()
        {
            return "Sword";
        }
    }
}