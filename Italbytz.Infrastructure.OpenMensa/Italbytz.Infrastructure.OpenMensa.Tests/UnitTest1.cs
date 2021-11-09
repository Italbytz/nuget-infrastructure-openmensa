using NUnit.Framework;

namespace Italbytz.Infrastructure.OpenMensa.Tests
{
    public class Tests
    {
        OpenMensaAPI api;

        [SetUp]
        public void Setup()
        {
            api = new OpenMensaAPI();
        }

        [Test]
        public async void Test1()
        {
            var canteens = await api.RetrieveCanteens();
            Assert.Pass();
        }
    }
}
