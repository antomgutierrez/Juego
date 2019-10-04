namespace RoleplayGame.Items
{
    /// <summary>
    /// Sword. Permite atacar.
    /// </summary>
    public class Guante : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
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
            return "Guante";
        }
    }
}