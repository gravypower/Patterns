namespace Patterns.AbstractFactory.People
{
    using Patterns.AbstractFactory.Drinks;

    /// <summary>
    /// The aaron.
    /// </summary>
    public class Aaron : ICocktailFactory
    {
        /// <summary>
        /// The favorite drink.
        /// </summary>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        public IDrink FavoriteDrink()
        {
            return new StirredMartini();
        }
    }
}
