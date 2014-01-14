namespace Patterns.AbstractFactory.People
{
    using Patterns.AbstractFactory.Drinks;

    /// <summary>
    /// The CocktailFactory interface.
    /// </summary>
    public interface ICocktailFactory
    {
        /// <summary>
        /// The mix drink.
        /// </summary>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        IDrink FavoriteDrink();
    }
}
