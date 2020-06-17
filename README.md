![Alt text](./cap_products_screen.png?raw=true "Title")
# Cake and Pastry Shop (CaP)
>Cake and Pastry Shop app is small app,which can be used to order cakes and pastry from.

CaP uses three design patterns-Abstract Factory(Creational), Decorator(Structural) and State(Behavioral).
# Design patterns used in CaP
## Abstract Factory
### Corresponding classes
* Abstract Factory:
  * SweetsFactory
* Concrete Factories:
  * ChocolateFactory & CreamFactory
* Products:
  * Cake
  * Pastry
* Concrete Products
  * ChocolateCakeBig
  * ChocolateCakeMedium
  * ChocolateCakeSmall
  * ChocolatePastryRegular
  * ChocolatePastrySmall
  * CreamCakeBig
  * CreamCakeMedium
  * CreamCakeSmall
  * CreamPastryRegular
  * CreamPastrySmall
  
## Decorator
### Corresponding classes
* Decorator:
  * SweetDecorator
* Concrete Decorators:
  * CakeFruitDecorator
  * CakeNutsDecorator
  * CakeSugarDecorator
  * PastryCacaoDecorator
  * PastryCaramelDecorator
  * PastrySugarDecorator
* Component:
  * Sweet
* Concrete components:
  * Cake
  * Pastry
  

## State
### Corresponding classes
* State:
  * IState (Interface)
* Context:
  * FinalOrder
* Concrete States:
  * FirstState
  * OrderProcessingState
  * OrderConfirmedState
  * OrderShippedState
  * OrderDeliveredState
## Other classes
* ItemTreeNode - describes tree node from the Cart tree,where products are being added.
* OrderItem - describes a single order item and collection of it's sub items.
* OrderItems - Stores a collection of items added to car during the shopping process.
* FinalOrder - used to construct the final order once user click the "Buy Now" button.
