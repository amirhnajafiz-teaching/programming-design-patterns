# Abstract Factory Pattern

## What is the pattern ?
<hr />
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