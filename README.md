# lab-strategy-pattern


Created a simple system that calculates shipping costs based on different strategies using strategy design pattern.

The shipping cost calculation can vary depending on factors such as shipping method, package weight, and distance. 



```mermaid

classDiagram
    class IShippingCostStrategy {
        +CalculateCost(weight: double, distance: double): double
    }

    class StandardShippingCost {
        +CalculateCost(weight: double, distance: double): double
    }

    class ExpressShippingCost {
        +CalculateCost(weight: double, distance: double): double
    }

    class OvernightShippingCost {
        +CalculateCost(weight: double, distance: double): double
    }

    class ShippingSystem {
        -shippingCostStrategy: IShippingCostStrategy
        +SetShippingCostStrategy(strategy: IShippingCostStrategy): void
        +CalculateShippingCost(weight: double, distance: double): double
    }

    IShippingCostStrategy <|-- StandardShippingCost
    IShippingCostStrategy <|-- ExpressShippingCost
    IShippingCostStrategy <|-- OvernightShippingCost
    ShippingSystem "1" *-- "1" IShippingCostStrategy : has

```
