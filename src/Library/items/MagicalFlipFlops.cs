namespace RoleplayGame.Items
{
    /// <summary>
    /// MagicalFlipFlop. Permite defenderse y atacar.
    /// </summary>
    public class MagicalFlipFlops : IAttackItem, IDefenseItem
    {
        FlipFlops chancla = new FlipFlops();
        Magic magia = new Magic();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
         public int AttackPower
        {
            get
            {
                return chancla.AttackPower + magia.AttackPower;
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
                return chancla.DefensePower + magia.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Magic";
        }
    }
}