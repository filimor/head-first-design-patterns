# Behavioral Patterns

## Strategy Pattern

The intent of the Strategy Pattern is to define a family of algorithms,
encapsulate each algorithm, and make them interchangeable. The Strategy Pattern
lets the algorithm vary independently from clients that use it. In addition the
pattern, defines a group of classes that represent a set of possible behaviors.
These behaviors can then be used in an application to change its functionality.

### Benefits

* An alternative to subclassing;
* Defines each behavior in its own class, which eliminates conditional
statements;
* Easier to extend a model to incorporate new behaviors without recoding the
application.

### When to Use

You should use the Strategy pattern when:

* Many related classes differ only in their behavior.
* You need different variants of an algorithm.
* An algorithm uses data unknown to clients.

## Observer Pattern

A subject may have any number of dependent observers and all observers are notified whenever the subject under goes a
change in state. In response, each observer will query the subject to synchronize its state with the state of the
subject. This kind of interaction is also known as publish-subscribe. The subject is the publisher of notifications and
sends out these notifications without having to know who its observers are. Any number of observers can subscribe to
receive notifications.
### Potential pitfalls of implementing the Observer pattern

You should be aware of a few potential pitfalls when implementing the Observer pattern:

* Generally, you need to make sure that the change of state is complete and that the object has a consistent state
before notifying observers of the change.
* Be clear about whether the order in which Observer objects are notified is or is not predictable.
* Do not let an Observer register itself twice with the same Observed object unless you are sure that is what it means
to do.

> Available at:
[https://www.gofpatterns.com/behavioral/patterns/strategy-pattern.php](https://www.gofpatterns.com/behavioral/patterns/strategy-pattern.php)
