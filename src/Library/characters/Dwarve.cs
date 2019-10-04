using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Enano
    /// </summary>
    
    public class Dwarve : Character
    {
        public Dwarve(string name)
            : base(name)
        {
            this.Health = 120;
            this.AddItem(new Sword());
        }
    }
}