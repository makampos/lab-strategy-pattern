namespace ShippingCostStrategy.Interfaces
{
    // Strategy Interface
    public interface IShippingCostStrategy
    {
        double CalculateCost(double weight, double distance);
    }
}