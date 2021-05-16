# Prototype Pattern

### What is the problem ?
<hr />
Sometimes you have a big class in your application that gets a lot of memory space
when it wants to be created.

When you want to use a lot of instances from this class, you may get into some troubles
in memory allocation and space.

### How does this pattern work ?
<hr />
In this pattern we use the <b><i>Clone()</i></b> method instead <b>New</b> keyword.

This creates a copy of our current object and stores it into a new variable.
The references are different but the fields are the same, and also inside objects
are the same.

But we only <b>New</b> one time and then we use <b><i>Clone()</i></b>and <b><i>Clear()</i></b> 
to create a copy and reset the fields of that object.

Ex :
```java
    Object myObj = new Object();
    Object mySecondObj = myObj.clone().clear();
```

This will help us with memory problem. 
But remember that we might get duplicate fields, so use this pattern when your object fields
duplication are not so important to you.