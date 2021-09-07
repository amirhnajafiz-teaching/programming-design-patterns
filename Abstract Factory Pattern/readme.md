# Abstract Factory Pattern

Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

Imagine that you’re creating a furniture shop simulator. Your code consists of classes that represent:
- A family of related products, say: Chair + Sofa + CoffeeTable.
- Several variants of this family. For example, products Chair + Sofa + CoffeeTable are available in these variants: Modern, Victorian, ArtDeco.

You need a way to create individual furniture objects so that they match other objects of the same family. Customers get quite mad when they receive non-matching furniture.
Also, you don’t want to change existing code when adding new products or families of products to the program. Furniture vendors update their catalogs very often, and you wouldn’t want to change the core code each time it happens.

The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces for each distinct product of the product family (e.g., chair, sofa or coffee table). Then you can make all variants of products follow those interfaces. For example, all chair variants can implement the Chair interface; all coffee table variants can implement the CoffeeTable interface, and so on.

The next move is to declare the Abstract Factory—an interface with a list of creation methods for all products that are part of the product family (for example, createChair, createSofa and createCoffeeTable). These methods must return abstract product types represented by the interfaces we extracted previously: Chair, Sofa, CoffeeTable and so on.


The client code has to work with both factories and products via their respective abstract interfaces. This lets you change the type of a factory that you pass to the client code, as well as the product variant that the client code receives, without breaking the actual client code.



## What is the pattern ?
This pattern solves the problem that we used to have in <b><i>Factory Pattern</i></b>.
Same idea and same problem in here.

But the only difference is that in here we don't have just one factory, we have many factories, and
the they are all using a same basic interface.

Init we just create a abstract class factory that each of our factories extend.
Then we create a big abstract factory that uses instances of those factories.

After that we just need to access the factory first, and then get its product.

Ex:
```java
    Object obj1 = AbstractFactory.InnerFactory1.getObject("type 1");
    Object obj2 = AbstractFactory.InnerFactory2.getObject("type 2");
```
