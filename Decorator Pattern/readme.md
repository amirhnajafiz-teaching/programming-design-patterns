# Decorator Pattern

### What is the problem ?
Same problem of having classes that are similar in the base features.<br />
The Decorator Pattern uses composition instead of inheritance to extend the functionality of an object at runtime.<br />
The Decorator Pattern is also known as Wrapper.<br />

In object-oriented programming, the decorator pattern is a design pattern that allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class.<br />
The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern. 

Decorator use can be more efficient than subclassing, because an object's behavior can be augmented without defining an entirely new object. 

## Advantage of Decorator Pattern:

- It provides greater flexibility than static inheritance.
- It enhances the extensibility of the object, because changes are made by coding new classes.
- It simplifies the coding by allowing you to develop a series of functionality from targeted classes instead of coding all of the behavior into the object.


## Usage of Decorator Pattern

- When you want to transparently and dynamically add responsibilities to objects without affecting other objects.
- When you want to add responsibilities to an object that you may want to change in future.
- Extending functionality by sub-classing is no longer practical.


### UML for Decorator Pattern
<img src="diagram.png" width="700" />