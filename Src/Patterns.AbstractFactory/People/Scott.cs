namespace Patterns.AbstractFactory.People
{
    using Patterns.AbstractFactory.Drinks;

    /// <summary>
    /// The scott.
    /// </summary>
    public class Scott : ICocktailFactory
    {
        /// <summary>
        /// The favorite drink.
        /// </summary>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        public IDrink FavoriteDrink()
        {
            return new CoffeeMartini();
        }
    }
}
