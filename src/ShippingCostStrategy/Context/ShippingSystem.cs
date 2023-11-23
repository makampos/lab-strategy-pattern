using System;
using ShippingCostStrategy.Interfaces;

namespace ShippingCostStrategy.Context
{
    public class ShippingSystem
    {
        private IShippingCostStrategy _shippingCostStrategy;

        public ShippingSystem(IShippingCostStrategy shippingCostStrategy)
        {
            _shippingCostStrategy =
                shippingCostStrategy ?? throw new ArgumentNullException(nameof(shippingCostStrategy));
        }

        public double CalculateShippingCost(double weight, double distance) => _shippingCostStrategy.CalculateCost(weight, distance);

        public void SetShippingCostStrategy(IShippingCostStrategy strategy) => _shippingCostStrategy = strategy;
    }
}