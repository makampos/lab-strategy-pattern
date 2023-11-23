using System;
using System.Reflection.Metadata;
using NUnit.Framework;
using ShippingCostStrategy.Context;
using ShippingCostStrategy.Interfaces;
using ShippingCostStrategy.Strategies;

namespace ShippingCostStrategyTests
{
    [TestFixture]
    public class ShippingCostStrategyTest
    {
        [Test]
        public void CalculateStandardShippingCost()
        {
            // Arrange
            IShippingCostStrategy standardShippingCost = new StandardShippingCost();
            var shippingSystem = new ShippingSystem(standardShippingCost);

            // Act
            var cost = shippingSystem.CalculateShippingCost(5, 100);

            // Assert
            Assert.AreEqual(12.5, cost);
        }

        [Test]
        public void CalculateExpressShippingCost()
        {
            // Arrange
            IShippingCostStrategy expressShippingCost = new ExpressShippingCost();
            var shippingSystem = new ShippingSystem(expressShippingCost);
            
            // Act
            var cost = shippingSystem.CalculateShippingCost(5, 100);

            // Assert
            Assert.AreEqual(36, cost );
        }
        
        [Test]
        public void CalculateOverNightShippingCost()
        {
            // Arrange
            IShippingCostStrategy overnightShippingCost = new OvernightShippingCost();
            var shippingSystem = new ShippingSystem(overnightShippingCost);
            
            // Act
            var cost = shippingSystem.CalculateShippingCost(5, 100);

            // Assert
            Assert.AreEqual(60, cost );
        }

        [Test]
        public void CalculateShippingCostWithoutStrategy()
        {
            // Arrange and Act
            var ex = Assert.Throws<ArgumentNullException>(() => new ShippingSystem(null));
            
            // Assert
            StringAssert.Contains("Value cannot be null", ex.Message);
        }
    }
}