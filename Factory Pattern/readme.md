# Factory Design Pattern

### What is the problem ?
<hr />
Sometimes you need to use objects that are basically the same in your application.
You may use interfaces and abstract classes to build your application. This is very officent way and
reduces the code duplicate and increases easy debuging and developing.<br />
Now when you create different classes and types from a base interface you may have a problem
when you want to instantiate.

For example imagine you have created a application for a selling car company. And for each type
of car type (ex. race car, sport car, truck, ...) you create a class that implements the Vehicle class.
Now when you want to create instanses you always have to becarefull to match the Object type with the class type.
This will increase the chances of making mistakes.

For example see the code below:
```java
    RaceCar car1 = new RaceCar();
    Truck car2 = new Truck();
    SportCar car3 = new RaceCar(); // This is a mistake that could happen
```

Also when you are working with a lot of classes and objects in your application.

### What does this pattern do ?
<hr />