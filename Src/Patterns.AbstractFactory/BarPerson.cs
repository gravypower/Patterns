namespace Patterns.AbstractFactory
{
    using Patterns.AbstractFactory.Drinks;
    using Patterns.AbstractFactory.People;

    /// <summary>
    /// The bar person.
    /// </summary>
    /// <typeparam name="T">
    /// The factory that supplies the drink to me made.
    /// </typeparam>
    public class BarPerson : IBarPerson 
    {
        /// <summary>
        /// The mix drink.
        /// </summary>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        public IDrink MixDrink<T>() where T : ICocktailFactory, new()
        {
            return new T().FavoriteDrink();
        }

        public IDrink MixDrink()
        {
            throw new System.NotImplementedException();
        }
    }
}
