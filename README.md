# Head First Design Patterns

> A set of labs to understand and practice design patterns (under development).

![Code Climate maintainability](https://img.shields.io/codeclimate/maintainability/filimor/head-first-design-patterns)
![GitHub repo size](https://img.shields.io/github/repo-size/filimor/head-first-design-patterns)
![GitHub license](https://img.shields.io/github/license/filimor/head-first-design-patterns)
![GitHub last commit](https://img.shields.io/github/last-commit/filimor/head-first-design-patterns)

*Read it in other languages:* [English](https://github.com/filimor/head-first-design-patterns/blob/master/README.md), [Português (Brasil)](https://github.com/filimor/head-first-design-patterns/blob/master/README.pt-BR.md)

## Description

This is a repository of the descriptions, UML class diagrams and examples of the
design patterns, based on the 'Head First Design Patterns' book but adapted to
C# language (.NET 5).

## Table of Contents

* [Behavioral Patterns](description/BehavioralPatterns.md)
* [Creational Patterns](description/CreationalPatterns.md)
* [Structural Patterns](description/StructuralPatterns.md)

## Class Diagrams

The [UML Class Diagrams](docs/HeadFirstDesignPatterns.asta) were built with Astah UML.

## Project Principles

The design patterns are guided by following principles:

1. Identify the aspects of your application that vary and separate them from
what stays the same.
2. Principle of Dependency Inversion: Program to an interface, not an implementation.
3. Favor composition above inheritance (HAS-A can be better than IS-A).
4. Strive for loosely coupled designs between objects that interact.
5. Open-Closed Principle: Classes should be open for extension, but closed for modification.
6. Principle of Least Knowledge: Talk only to your immediate friends.
7. Hollywood Principle: Don't call us, we'll call you.

## Design Patterns

| Padrão | Descrição |
|-|-|
| **ADAPTER** | Converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces. |
| **COMMAND** | Encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log request, and support undoable operations. |
| **DECORATOR** | Attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. |
| **FACADE** | Provides an unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use. |
| **FACTORY** | Defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses. |
| **OBSERVER** | Defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically. |
| **SINGLETON** | Ensures a class has only one instance, and provides a global point of access to it. |
| **STRATEGY** | Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it. |
| **TEMPLATE METHOD** | Defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. |

## Build With

* [Microsoft Visual Studio 2019 Community Edition](https://visualstudio.microsoft.com/vs/community/)
* [Visual Studio Code](https://code.visualstudio.com/)
* [Astah UML Model Version 39](https://astah.net/products/astah-uml/)

## Como Contribuir

If you want to help to translate the project, include other languages or warn me
about some bug you're welcome! Please follow our
[code of conduct](https://github.com/filimor/head-first-design-patterns/blob/master/CODE_OF_CONDUCT.md).

## Translations

* [English](https://github.com/filimor/head-first-design-patterns/blob/master/README.md)
* [Português (Brasil)](https://github.com/filimor/head-first-design-patterns/blob/master/README.pt-BR.md)

## Credits

* [@filimor](https://github.com/filimor/)
* [@bethrobson](https://github.com/bethrobson/Head-First-Design-Patterns)
(Book's repository)

## Contact

* [E-mail](mailto:filimor@posteo.net)
* [LinkedIn](https://www.linkedin.com/in/filimor/)
* [Twitter](https://www.twitter.com/filimorbr/)

## License

This project is licensed under the MIT License - see the
[LICENSE.md](https://github.com/filimor/head-first-design-patterns/blob/master/LICENSE "MIT")
file for details.
