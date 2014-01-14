namespace Patterns.AbstractFactory.People
{
    using Patterns.AbstractFactory.Drinks;

    /// <summary>
    /// The mr bond.
    /// </summary>
    public class MrBond : ICocktailFactory
    {
        /// <summary>
        /// The favorite drink.
        /// </summary>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        public IDrink FavoriteDrink()
        {
            return new ShakenMartini();
        }
    }
}
