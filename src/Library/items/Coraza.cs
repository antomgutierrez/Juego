namespace RoleplayGame.Items
{
    /// <summary>
    /// Shell. Permite defenderse mucho
    /// </summary>
    public class Coraza : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 50;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}