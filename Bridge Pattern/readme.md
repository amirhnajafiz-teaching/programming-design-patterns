# Bridge Design Pattern

### What is the problem ?
<hr />
Whenever you have big complex data structures, and you need to use nested inheritance 
and abstract classes and interfaces, you might get a little bit confused.

You might just create a application that uses 2 types of one class and each of
them uses 2 other types.

Basically you can create 4 type of class for each one.
Example:
```java
    AB temp = new AB();
    AC temp1 = new AC();
    DB temp2 = new DB();
    DC temp3 = new DC();
```

### How this pattern works ?
<hr />
Instead of creating 4 types of classes, you can use abstract class and also interfaces,
to place the second type as a field in the first one.

Example:
```java
    class A 
    {
        Type type;
        public A (Type type)
        {
            this.type = type;
        }       
    }   

    interface Type
    {
        // Empty    
    }  
    
    class C implements Type 
    {
        // Empty
    }
 
```

```java
    A tempTypeAC = new A(new C())
    B tempTypeBD = new B(new D())
```

This method is useful when you want to bind the implementation with creating,
and for mapping the classes.
