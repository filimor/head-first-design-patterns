# Structural Design Patterns

Structural design patterns are design patterns that ease the design by
identifying a simple way to realize relationships between entities. Structural
patterns are for tying together existing function.

## Decorator Pattern

The Decorator pattern enables you to add or remove object functionality without
changing the external appearance or function of the object. It changes the
functionality of an object in a way that is transparent to its clients by using
an instance of a subclass of the original class that delegates operations to the
original object. The Decorator pattern attaches additional responsibilities to
an object dynamically to provide a flexible alternative to changing object
functionality without using static inheritance.

### Benefits

* More flexibility than static inheritance.
* Avoids feature-laden classes high up in the hierarchy.
* Simplifies coding because you write a series of classes, each targeted at a
specific part of the functionality, rather than coding all behavior into the
object.
* Enhances the object's extensibility because you make changes by coding new
classes.

### When To Use

* You want to add responsibilities to individual objects dynamically and
transparently, that is without affecting other objects.
* You want to add responsibilities to the object that you want to change in the
future.
* When extension by static sub-classing is impractical.

> Available at:
[https://www.gofpatterns.com/structural-patterns/index.php](https://www.gofpatterns.com/structural-patterns/index.php)
