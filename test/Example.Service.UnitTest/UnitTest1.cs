using Example.Service.Services;
using NUnit.Framework;



namespace Example.Service.UnitTest
{
    public class Tests
    {

        [Test]
        public void ShouldReturnAListOfStaticValues()
        {
        var unitUnderTest = new ValuesService();
	    var values = unitUnderTest.GetValues();
	    Assert.That(values, Is.EqualTo(new[] {"Value1", "Value2", "Value3"}));
        }
    }
}
