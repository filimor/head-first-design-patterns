# Behavioral Design Patterns

In software engineering, behavioral design patterns are design patterns that
identify common communication patterns between objects and realize these
patterns. By doing so, these patterns increase flexibility in carrying out
this communication.

Behavioral patterns influence how state and behavior flow through a system.
By optimizing how state and behavior are transferred and modified, you can
simplify, optimize, and increase the maintainability of an application.

## Strategy Pattern

The intent of the Strategy Pattern is to define a family of algorithms,
encapsulate each algorithm, and make them interchangeable. The Strategy Pattern
lets the algorithm vary independently from clients that use it. In addition the
pattern, defines a group of classes that represent a set of possible behaviors.
These behaviors can then be used in an application to change its functionality.

### Benefits

* An alternative to subclassing.
* Defines each behavior in its own class, which eliminates conditional
statements.
* Easier to extend a model to incorporate new behaviors without recoding the
application.

### When to Use

* Many related classes differ only in their behavior.
* You need different variants of an algorithm.
* An algorithm uses data unknown to clients.

## Observer Pattern

The Observer pattern provides a way for a component to flexibly broadcast
messages to interested receivers. It defines a one-to-many dependency between
objects so that when one object changes state, all its dependents are notified
and updated automatically.

### Benefits

* Abstract coupling between subject and observer.
* Support for broadcast communication.

### When to Use

* A change to one object requires changing the other object and you do not know
how many objects need to change. An object should be able to notify other
objects without making assumptions about the identity of those objects.

> Available at:
[https://www.gofpatterns.com/behavioral/index.php](https://www.gofpatterns.com/behavioral/index.php)
