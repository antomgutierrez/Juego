using System;
using System.Collections.Generic;
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
        public List<Gema> Lista_Gemas;

        public int AttackPower
        {
            get
            {
                return ataque;
            }
        }

        public Guante()
        {       
        }
        
        public void Add_Gemas(int gema)
        {
            if (gema < 0)
            {
                Console.WriteLine("Ingrese una cantidad positiva.");
            }
            if (gema + Lista_Gemas.Count <= 5)
            {
                for (int i = 0; i < gema; i++)
                {           
                    Gema nueva_gema = new Gema();
                    Lista_Gemas.Add(nueva_gema);
                }
                ataque = ataque + 20 * gema;
            }
            else
            {
                Console.WriteLine("Excede el numero de gemas posibles");
            }
            
        }

        public override string ToString()
        {
            return "Guante";
        }
    }
}