using ShippingCostStrategy.Interfaces;

namespace ShippingCostStrategy.Strategies
{
    public class ExpressShippingCost : IShippingCostStrategy
    {
        public double CalculateCost(double weight, double distance)
        {
            // Express shipping cost calculation (higher cost per unit weight and distance)
            return weight * 1.2 + distance * 0.3;
        }
    }
}