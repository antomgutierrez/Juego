namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        FlipFlops = 3,
        Sling = 4,
        Coraza = 5,
        Sword = 6,
        Guante = 7,
        MagicalFlipFlops = 8,
    }

    /// <summary>
    /// Creador de elementos.
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Sling : return new Sling();
                case ItemType.Sword: return new Sword();
                case ItemType.Coraza: return new Coraza();
                case ItemType.Guante: return new Guante();
                case ItemType.FlipFlops: return new FlipFlops();
                case ItemType.MagicalFlipFlops: return new MagicalFlipFlops();

                default: return null;
            }
        }
    }
}