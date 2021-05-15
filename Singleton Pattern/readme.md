# Singleton Pattern

### What is the problem ?
<hr />
Imagine that you have a class in your application that you want it to have a unique
instance. Mean that there are no duplicate instances of this object.

This can be needed when you want to create objects like Cache, Logger , ...
Its better that these objects have only one instance.

To do this, we use singleton pattern, which limits the number of instances of an object ot one.

### How this pattern works ?
<hr />
In this pattern our class constructor is private, and it uses only one static field
that is itself ( with other fields of class ). Now only this field is static and it has
only one other static method called <b><i>"getInstance()"</i></b> which will get the reference
of that object for us.

It also initialize it, if it was the first time that our method was called.
```java
public Singleton {
    private static Singleton instance;
    private Singleton() {
    }   
    public static Singleton getInstance()
    {   
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
```
<br />
With this pattern, we can only have one instance of our object.