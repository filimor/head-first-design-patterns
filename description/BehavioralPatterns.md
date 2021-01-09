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

Available at:
[https://www.gofpatterns.com/behavioral/patterns/strategy-pattern.php](https://www.gofpatterns.com/behavioral/patterns/strategy-pattern.php)
