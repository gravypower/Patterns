namespace Patterns.AbstractFactory
{
    using Patterns.AbstractFactory.Drinks;
    using Patterns.AbstractFactory.People;

    /// <summary>
    /// The BarPerson interface.
    /// </summary>
    public interface IBarPerson
    {
        /// <summary>
        /// The mix drink.
        /// </summary>
        /// <typeparam name="T">
        /// The factory that supplies the drink to me made.
        /// </typeparam>
        /// <returns>
        /// The <see cref="IDrink"/>.
        /// </returns>
        IDrink MixDrink<T>() where T : ICocktailFactory, new();
    }
}