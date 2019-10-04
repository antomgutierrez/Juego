using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
using RoleplayGame.Scenarios;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Program
{
    /// <summary>
    /// Este escenario permite crear personajes, items y encuentros
    /// desde la terminal en forma dinámica.
    /// </summary>
    public class Scenario: IScenario
    {
        /// <summary>
        /// Los personajes creados
        /// </summary>
        /// <typeparam name="Character"></typeparam>
        /// <returns></returns>
        protected List<Character> characters = new List<Character>();

        /// <summary>
        /// Código de inicialización del escenario.
        /// </summary>
        public virtual void Setup()
        {
            this.BuildCharacters();
        }

        /// <summary>
        /// Código de ejecución del escenario.
        /// </summary>
        public virtual void Run()
        {
            this.RunEncounters();
        }

        /// <summary>
        /// Ejecución de un encuentro. Se construye de forma
        /// dinámica mediante interacción con el usuario.
        /// </summary>
        protected virtual void RunEncounters()
        {
            Encounter encounter = this.BuildEncounter();
            while (encounter != null)
            {
                encounter.DoEncounter();
                this.RemoveDeadCharacters();
                encounter = this.BuildEncounter();
            }
        }

        /// <summary>
        /// Construcción de un encuentro mediante entrada por la
        /// terminal.
        /// 
        /// Si quedan menos de dos personajes, la función retorna null.
        /// Si la entrada es vacía se retorna null.
        /// </summary>
        /// <returns>El encuentro creado</returns>
        protected virtual Encounter BuildEncounter()
        {
            if (this.LessThanTwoCharactersLeft)
            {
                return null;
            }
            EncounterType type = this.ReadEncounterType();
            if (type == default(EncounterType))
            {
                return null;
            }

            Character character1 = this.SelectCharacter("Select one character:");
            Character character2 = this.SelectCharacter("Select another character:");
            Encounter encounter = EncounterFactory.GetEncounter(type, character1, character2);

            if (encounter is ExchangeEncounter)
            {
                IItem item = SelectItem(character1.Items);
                ((ExchangeEncounter)encounter).AddItemToExchange(item);
            }
            
            encounter.Reporter = new ConsoleReporter();
            
            return encounter;
        }

        protected bool LessThanTwoCharactersLeft
        {
            get
            {
                return characters.Count < 2;
            }
        }

        /// <summary>
        /// Construcción de los personajes mediante interacción por
        /// la terminal.
        /// 
        /// La función termina cuando la entrada de usuario es vacía.
        /// </summary>
        protected virtual void BuildCharacters()
        {
            Character Nico = new Elf("Nico");
            Character Mateo = new Dwarve("Mateo");
            Character Diego = new Wizard("Diego");
            Character Anto = new Troll("Anto");

            List<Character> listaCaracteres = new List<Character>();
            listaCaracteres.Add(Nico);
            listaCaracteres.Add(Mateo);
            listaCaracteres.Add(Diego);
            listaCaracteres.Add(Anto);            

            Array nombreItems = Enum.GetNames(typeof(ItemType));
            Random items = new Random();

            foreach (Character personaje in listaCaracteres)
            {
                int randomItem = items.Next(0, nombreItems.Length);
                ItemType tipo = this.ReadItemType(); 
                IItem item = ItemFactory.GetItem(tipo);
                personaje.AddItem(nombreItems.GetValue(randomItem));
                this.characters.Add(personaje);

                Console.WriteLine($"Built {personaje}");

                
            }
        }

    }
}