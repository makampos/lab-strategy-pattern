using ShippingCostStrategy.Interfaces;

namespace ShippingCostStrategy.Strategies
{
    // Concrete Strategies
    public class StandardShippingCost : IShippingCostStrategy
    {
        public double CalculateCost(double weight, double distance)
        {
            // Basic shipping cost calculation
            return weight * 0.5 + distance * 0.1;
        }
    }
}