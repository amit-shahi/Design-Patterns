# Software Design Patterns
Software Design Patterns: Examples in C# for Creational, Structural, Behavioural design patterns.

## Creational design patterns



1. Abstract Factory
     ```
    Creates an instance of several families of classes
      ```

2. Builder
      ```
    Separates object construction from its representation
      ```

3. Factory Method
     ```
    Creates an instance of several derived classes
      ```

4. Object Pool
      ```
    Avoid expensive acquisition and release of resources by recycling objects that are no longer in use
      ``` 

5. Prototype
     ```
    A fully initialized instance to be copied or cloned
      ```
     
6. Singleton
      
* A class of which only a single instance can exist
     
* This pattern is used when we want to ensure that only one object of a specific class needs to be created. All future references to the objects are referred to the same underlying instance created.

* Singleton controls concurrent access to the same resource.

* It ensures that, there is only one object available across the application in a controller state.

* Make sure to provide global access to the instance by 
  - Making sure all constructors of the class is declared as private
  - Provide static method that returns a reference to the instance.
  - The instance is tored as a private static variable.
  - Make sure to delcare class as sealed.
  



## Structural design patterns

1. Adapter
    ```
        Match interfaces of different classes
    ```

2. Bridge
 ```
Separates an object’s interface from its implementation
 ```

3. Composite
 ```
A tree structure of simple and composite objects
 ```

4. Decorator
 ```
Add responsibilities to objects dynamically
 ```

5. Facade
 ```
A single class that represents an entire subsystem
 ```

6. Flyweight
 ```
A fine-grained instance used for efficient sharing
 ```

7. Private Class Data
 ```
Restricts accessor/mutator access
 ```

8. Proxy
 ```
An object representing another object
 ```



## Behavioral design patterns

1. Chain of responsibility
 ```
A way of passing a request between a chain of objects
 ```

2. Command
 ```
Encapsulate a command request as an object
 ```

3. Interpreter
 ```
A way to include language elements in a program
 ```

4. Iterator
 ```
Sequentially access the elements of a collection
 ```
 
5. Mediator
 ```
Defines simplified communication between classes
 ```

6. Memento
 ```
Capture and restore an object's internal state
 ```

7. Null Object
 ```
Designed to act as a default value of an object
 ```

8. Observer
 ```
A way of notifying change to a number of classes
 ```

9. State
 ```
Alter an object's behavior when its state changes
 ```

10. Strategy
 ```
Encapsulates an algorithm inside a class
 ```

11. Template method
 ```
Defer the exact steps of an algorithm to a subclass
 ```

12. Visitor
 ```
Defines a new operation to a class without change
 ```
