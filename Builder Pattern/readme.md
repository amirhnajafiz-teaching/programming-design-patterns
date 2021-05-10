## Builder Pattern

#### What is the problem ?
Imagine you are creating a class in your application. This class has a constructor so you can set the values of its fields.

When you want to build an instance of that class as an object, you need to pass the data in correct order,
so you get each value in its right field.<br />
Now for the classes with few fields, said 2 or 3, you won't have a problem. 
But what if you had a class with 10 input fields in constructor ?

Its hard to remember the correct order of your fields in constructor.
For example lets check this class constructor:
```java
public MyClass (long id, long parent, long left, long right)
```

Now lets see the problem in instantiating:
```java
MyClass temp1 = new MyClass(12L, 13L, 0L, 0L);
MyClass temp2 = new MyClass(13L, 14L, 0L, 0L);
```

As you can see its hard to tell which long input is for which field when we instantiate.
You could set the wrong order and cause problem in your application.

#### How this pattern works ?
By creating an inner class and create setter methods, we create our objects in way more readable and easy to use.

We create a Builder class inside our class and we pass the data to its setters and then we call a <b>Build</b> method to
get our class instance.

In this pattern the original constructor is private and it will be built by the Builder class.

After that we can create our objects like this:
```java
Myclass temp = new MyClass.Builder()
    .setId(12L)
    .setLeft(0L)
    .setRight(1L)
    .setParent(13L)
    .build();
```

As you can see, now our code is more readable and can be debug easily, and for long constructors
it reduces the chances of making mistakes while you are instantiating.
