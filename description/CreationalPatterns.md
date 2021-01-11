# Creational Design Patterns

In software engineering, creational design patterns are design patterns that
deal with object creation mechanisms, trying to create objects in a manner
suitable to the situation. The basic form of object creation could result in
design problems or added complexity to the design. Creational design patterns
solve this problem by somehow controlling this object creation.

Creational design patterns are composed of two dominant ideas.

* One is encapsulating knowledge about which concrete classes the system use.
* Another is hiding how instances of these concrete classes are created and
combined.

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
[https://www.gofpatterns.com/creational/index.php](https://www.gofpatterns.com/creational/index.php)