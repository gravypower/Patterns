namespace Patterns.AbstractFactory.Tests
{
    using NUnit.Framework;

    using Patterns.AbstractFactory.Drinks;
    using Patterns.AbstractFactory.People;

    [TestFixture]
    public class BarPersonTests
    {
        [Test]
        public void CanCreateShakenMartiniForMrBond()
        {
            var barPerson = new BarPerson();
            var drink = barPerson.MixDrink<MrBond>();

            Assert.That(drink, Is.TypeOf<ShakenMartini>());
        }

        [Test]
        public void CanCreateStirredMartiniForAaron()
        {
            var barPerson = new BarPerson();
            var drink = barPerson.MixDrink<Aaron>();

            Assert.That(drink, Is.TypeOf<StirredMartini>());
        }

        [Test]
        public void CanCreateCoffeeMartiniForScott()
        {
            var barPerson = new BarPerson();
            var drink = barPerson.MixDrink<Scott>();

            Assert.That(drink, Is.TypeOf<CoffeeMartini>());
        }
    }
}
