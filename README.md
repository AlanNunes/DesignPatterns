# What is a Design Pattern?

Design Patterns are solutions to common problems that eventually appears while developing a software. Design Patterns are good because they use best practices for solving problems. It looks like a template of how to solve a common problem. 

## Facade Pattern

Facade Pattern encapsulates the complexity of a system, library or API. You use a facade when you i.e. need to use a authentication library that has bunch of methods but you just need some methods, the login e logout methods.
Facade will wrap the complexity of a interface and makes the code looks simpler to client that consumes it.

[Authentication using Facade Pattern](VideoConverter/)

## Adapter Pattern

Adapter Pattern is used when you want to use a interface as another interface that is incompatible.

[USB to Ethernet using Adapter Pattern](USBToEthernet/)

## Decorater Pattern

Decorator Pattern adds and changes the behavior of an object at runtime. Unlike inheritance, the behaviors changes do not affect others objects. Inheritance changes behavior at compile time meanwhile decorator pattern does it at runtime.

[Notifier using Decorator Pattern](Notifier/)

Source: [refactoring.guru](https://refactoring.guru/design-patterns/decorator)

## Notification Pattern

An object that collects together information about errors and other information in the domain layer and communicates it to the presentation. ([Definition from Martin Fowler](https://martinfowler.com/eaaDev/Notification.html))

[Student model validation using Notification Pattern](Student/)

## Strategy Pattern

This pattern allows client to use a family of algorithms interchangeably. Imagine the client can use different implementations of a searching algorithm (binary search or linear search). As the client can interchange theses algorithms, you can define a search strategy that wraps a searching algorithm to perform the task. Then the client can intechange at runtime which searching algorithm to use.

TODO: ADD A SAMPLE CONSOLE PROJECT
