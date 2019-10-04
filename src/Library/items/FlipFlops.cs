namespace RoleplayGame.Items
{
    /// <summary>
    /// FlipFlops. Permite atacar hardcore style.
    /// </summary>
    public class FlipFlops : IAttackItem
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

        public override string ToString()
        {
            return "Flip Flops";
        }
    }
}