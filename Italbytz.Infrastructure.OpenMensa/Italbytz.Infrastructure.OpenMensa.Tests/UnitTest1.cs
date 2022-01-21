using System;
using System.Threading.Tasks;
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
        public async Task TestGetCanteens()
        {
            var canteens = await api.GetCanteens();
            Assert.IsTrue(canteens.Count > 0);
        }

        [Test]
        public async Task TestGetCanteenDays()
        {
            var canteenDays = await api.GetCanteenDays(1);
            Assert.NotNull(canteenDays);
        }

        [Test]
        public async Task TestGetMeals()
        {
            try
            {
                var meals = await api.GetMeals(1, DateTime.Now);
                Assert.NotNull(meals);
            }
            catch (Exception ex)
            {
                Assert.True(ex is MensaClosedException || ex is NoMealsForDateException);
            }

        }
    }
}
