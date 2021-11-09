﻿using System.Threading.Tasks;
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
            Assert.IsTrue(canteenDays.Count > 0);
        }

        [Test]
        public async Task TestGetTodaysMeals()
        {
            var meals = await api.GetTodaysMeals(1);
            Assert.IsTrue(meals.Count > 0);
        }
    }
}
