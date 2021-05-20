# Adapter Design Pattern

### What is the problem ?
Sometimes in your application you have two or more interfaces that are incompatible.
Means that they were created in different ways and you can not match them together.

Also pay attention that you cannot change nigher of the interfaces, cause you might not
know how they were implemented.

What you need is an Adapter to make this available for you to match these interfaces
with each other without changing them.

### How this pattern works ?
By creating an interface based on of your interfaces and then use a instance
to keep the other interface inside your adapter.

By doing this, you allow the interfaces to get connected to each other easily.

This might be useful when your working with different APIs or sending requests from
clients to different client handling servers.

Or you might use it in I/O streams. For example changing a Array to List or ....   

See the example below:
```java
    BaseInterface instance = new BaseInterface();
    Adapter adapter = new Adapter(instance);
    OtherInterface other = new OtherInterface();
    
    ArrayList<interface> myList = new ArrayList();
    myList.add(other);
    myList.add(adapter); // Because we couldn't store the Base interface in to this list type
```