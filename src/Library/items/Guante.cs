using System;
namespace RoleplayGame.Items
{
    /// <summary>
    /// Guante Por si solo no hace nada, pero si se combina con gemas sirve para atacar
    /// </summary>
    public class Guante : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        /// <summary>
        /// ataque: se inicia en 0
        /// </summary>
        public int ataque = 0;
        /// <summary>
        /// gemas se inician en cero
        /// </summary>
        public int gemas = 0;
        public int AttackPower
        {
            get
            {
                return ataque;
            }
        }

        public void Agregar_Gema(int gema)
        {
            if (gema < 0)
            {
                Console.WriteLine("Ingrese un numero positivo de gemas");
            }

            if (gemas + gema < 5)
            {
                ataque = ataque + 20 * gema;
                gemas = gemas + gema;
                
            }
            else
            {
                Console.WriteLine("Excede número de gemas posibles");
            }

        }

        public override string ToString()
        {
            return "Guante";
        }
    }
}