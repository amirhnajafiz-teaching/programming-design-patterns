# Object Pool Pattern

### What's the problem?
When you have a large class that gets a lot of memory. Sometimes its good 
to set a limit for the number of instances that the class could have.<br />

Now you can do this also by <i>Singleton Pattern</i> but when you use Object pool
you can have resuseablitiy and objects are cached so it will manage the memory space.

But there are some problems with this pattern for example:
<ul>
    <li>
        Complex implements
    </li>
    <li>
        Thread issuses ( need thread safe )
    </li>
    <li>
        Relay on other patterns
    </li>
    <li>
        Low popularity
    </li>
</ul>

### How it works?
By creating a hash-map of objects and use them as cached objects.

E.x:
```java
    Tool firstTool = (Tool) toolPool.create();
    Tool secondTool = (Tool) toolPool.create();

    toolPool.checkOut(firstTool);
    toolPool.checkOut(secondTool);
```