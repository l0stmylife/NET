using NUnit.Framework;

namespace Example.Service.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnAListOfStaticValues()
        {
            var unitUnderTest = new ValuesService();
	    var values = unitUnderTest.GetValues();
	    Assert.That(values, Is.EquelTo(new[] {"Value1", "Value2", "Value3"}));
        }
    }
}
