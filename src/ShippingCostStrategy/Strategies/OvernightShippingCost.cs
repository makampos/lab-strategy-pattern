using ShippingCostStrategy.Interfaces;

namespace ShippingCostStrategy.Strategies
{
    public class OvernightShippingCost : IShippingCostStrategy
    {
        public double CalculateCost(double weight, double distance)
        {
            // Overnight shipping cost calculation (highest cost)
            return weight * 2 + distance * 0.5;
        }
    }
}