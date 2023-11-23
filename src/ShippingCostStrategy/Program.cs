using System;
using ShippingCostStrategy.Context;
using ShippingCostStrategy.Interfaces;
using ShippingCostStrategy.Strategies;

namespace ShippingCostStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of strategies
            IShippingCostStrategy standardShippingStrategy = new StandardShippingCost();
            IShippingCostStrategy expressShippingStrategy = new ExpressShippingCost();
            IShippingCostStrategy overnightShippingStrategy = new OvernightShippingCost();
            
            // Create an instance of ShippingSystem with a default strategy
            var shippingSystem = new ShippingSystem(standardShippingStrategy);
            
            // Calculate the standard shipping
            CalculateAndPrintShippingCost(shippingSystem, 5, 100);
            
            // Change the shipping strategy to express
            shippingSystem.SetShippingCostStrategy(expressShippingStrategy);
            CalculateAndPrintShippingCost(shippingSystem, 5, 100);
            
            // Change the shipping strategy to overnight
            shippingSystem.SetShippingCostStrategy(overnightShippingStrategy);
            CalculateAndPrintShippingCost(shippingSystem, 5, 100);

            static void CalculateAndPrintShippingCost(ShippingSystem shippingSystem, double weight, double distance)
            {
                double cost = shippingSystem.CalculateShippingCost(weight, distance);
                Console.WriteLine($"Shipping Cost {cost}");
            }
        }
    }
}