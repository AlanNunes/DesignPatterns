# What is a Design Pattern?

Design Patterns are solutions to common problems that eventually appears while developing a software. Design Patterns are good because they use best practices for solving problems. It looks like a template of how to solve a common problem. 

## Facade Pattern

Facade Pattern encapsulates the complexity of a system, library or API. You use a facade when you e.g. need to use a authentication library that has bunch of methods but you just need some methods, the login e logout methods.
Facade will wrap the complexity of a interface and makes the code looks simpler to client that consumes it.

[Authentication using Facade Pattern](VideoConverter/)

## Adapter Pattern

Adapter Pattern is used when you want to use a interface as another interface that is incompatible.

[USB to Ethernet using Adapter Pattern](USBToEthernet/)

Good explanation with examples: [dotnettutorials.net](https://dotnettutorials.net/lesson/adapter-design-pattern/)

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

## Mediator Pattern

Encapsulate and manage the communication between objects. The objects in this pattern communicate through a mediator rather than directly to other components.
The sample below shows the mediator Motherboard which manage the communication between components (mouse, keyboard and processor).

[Motherboard Mediator](ComputerMotherBoardMediator/)

## Factory Method Pattern

In this pattern we must have an interface to represent our product that is created by the factory. We need to have an abstract factory to define what product is to be created and then the concrete factories for creating their individual products. But theses individual products implements the same interface "product" and then the logic and type of product beeing created is encapsulated in each individual concrete factory. The products are created by calling a method in the factory.

[A Shop that sells Smartphones](FactoryMethod/)
