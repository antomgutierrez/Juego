namespace RoleplayGame.Items
{
    /// <summary>
    /// FlipFlops. Permite atacar hardcore style.
    /// </summary>
    public class FlipFlops : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 100;
            }
        }
        public int DefensePower
        {
            get
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Flip Flops";
        }
    }
}