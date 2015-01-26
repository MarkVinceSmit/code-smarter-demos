[![Alt text](https://raw.githubusercontent.com/LearningLine/essential-swift-demos/master/images/dmlog.png)](https://develop.com)

Code & Test Smarter with Design Patterns Demos
===========

Welcome to [DevelopMentor](https://develop.com)'s demos repository for our 
[Code & Test Smarter with Design Patterns Course](https://www.develop.com/training-course/.net-design-patterns-training). 

If you are in this course *right now*, **start by selecting your course's branch** and then just click 'Download ZIP' or clone this repo to your system. On the other hand, if you took my course awhile ago and want access to the demos, your course has probably been **moved to another branch**. Use the branches dropdown to find it just contact me (email address is listed in my github profile).

If you are **not** in one of our courses, enjoy the samples and please consider DevelopMentor for your [.NET Training](https://www.develop.com/training-courses/.net)!

Cheers, 
[@DevelopMentor_](https://twitter.com/developmentor_) - 
[https://www.develop.com/](https://develop.com)

What you will learn in this course
--------------------

Reuse solutions, not just code. Code Smarter with Design Patterns helps you identify problems that occur repeatedly in your code, and solve those problems in a standardized way. Wrap your head around the concept of the design pattern; a programming solution or template that can be used in many different situations, and discover new tools for creating successful software.

Course outline and topics
----------------

**Why Patterns**

This chapter discusses the reasons why you should study design patterns. Design patterns offer the ability to reuse solutions not just code. By reusing already established designs, you get a head start on problems and avoid gotchas; you benefit by learning from the experience of others; you do not have to reinvent solutions for commonly recurring problems.

Design patterns establish a common terminology allowing developers to use a common vocabulary and share a common viewpoint of the problem. Design patterns provide a common point of reference during the analysis and design phase of a project.

The course will use UML as a means to communicate pattern intent, and this chapter will introduce key UML concepts.

**Adapter & Facade**

The adapter is a design pattern that translates one interface for a class into a compatible interface, while the facade provides a simplified interface to a larger body of code, such as a class library. This module covers both patterns and describes best practices with each.

**Singleton**

Some solutions require the use of a single object instance across the whole solution, for example naming services, cached objects. This chapter will introduce the singleton pattern as a solution, along with variations for thread safety, and other varieties of single instance based on thread affinity.

**Creation Patterns**

There are occasions when you want to decouple the knowledge of which type to create from the client code. This is essential for effective unit testing. There are a variety of creation pattern that will allow you do this by encapsulating the necessary knowledge of how to create the object thus allowing the actual implementation used to vary. In this chapter we will look at the Factory, Builder and Prototype patterns.


**Observer**

The ability to notify interested entities of changes to an object state is a fundamental requirement of most Object oriented solutions. There are many ways to do this but there is a danger that we will build a tightly coupled system, we prefer to build a loosely coupled system. The typical way of implementing the observer pattern is to use interfaces, but we will show that delegates and events are a far more flexible and efficient way of implementing the pattern on the .NET framework.

**Strategy and Template**

What we can be 100% sure of with software is that constantly needs to evolve. What we also know is every time we change existing working code there is a risk that we will break it. What we need is an approach that will allow the software to evolve without having to modify existing working code. The strategy and template patterns allow us to build solutions that can evolve without the risk of effecting existing well tested code.

**Iterator, Composite and Visitor**

There is often a need to access every object inside an object hierarchy, user interface control objects, documents, business entities, file systems. etc. The iterator pattern provides a standard means to achieve this, .NET provides a standard implementation of this; further the C# language simplifies the implementation further through language extensions. The visitor pattern gives us the ability to layer behavior onto the hierarchy without the need to change the underlying implementation of the hierarchy. Continuing the theme closed for modification open for extension.


**Decorator**

One of the key design pattern goals is to write code that is closed for modification and open to extension, this pattern will show that an object's behavior and responsibilities can be extended at runtime, as opposed to design time using inheritance. This will allow us to combine a variety of behaviors far more efficiently that normal inheritance. Examples of decorators in the framework are BufferedStream, SynchronizationWrappers, and XmlValidatingReaders.

**Command**

The command pattern allows us to encapsulate invocation, allowing the invoker to be decoupled from the client and the recipient, this enables us to build a variety of different invokers to deliver custom thread pooling, and invocation logging to build fault tolerant solutions. We continue to extend the command pattern to not only encapsulate forward invocation but also undo invocation, allowing us to build a complex undo sequence through a series of simple undo commands.

**State**

In many cases object behavior will depend on the state an object is in, we typically model the internals of objects through the use of finite state machine. This pattern provides a means to map a finite state machine into a series of classes where each class represents a different state, and thus providing different behaviors. This approach allows us to add new states and transitions without effecting existing code, continuing the theme closed for modification, open for extension.


**Proxy, Interceptor**

The proxy pattern manages the invocation of an object, by hiding the true nature of the location and invocation mechanism of the object, typically used to make remote method calls. Proxies have a host of uses from the conventional RPC style to more elaborate uses such as virtual proxies, security proxies and caching proxies. Proxies can be built manually, using the CLR or using third party libraries that can be used to automate the process. We will look at all three approaches to building effective proxies.

**ORM's and Repository Pattern**

Object Relational mappers provide a good separation of business logic from persistence logic; however using a given ORM often leads to code being coupled to a particular ORM. This has two effects, one making it hard to test application logic without a physical database, two results in your code being coupled to a given provider. The Repository pattern creates an anti-corruption layer to allow you to take advantage of an ORM whilst still maintaining your ability to test, and change your choice of ORM simply and cleanly. Finally we round of this module looking at Unit Of Work pattern to aggregate many repositories and provide centralized change tracking across all the repositories. In this chapter we will use MS Entity Framework (EF) as an ORM, evolving code from using EF directly to utilizing the patterns thus taking full advantage of the ORM whilst keeping our code flexible and testable.

**MVC**

The Model/View/Controller design pattern provides guidance on how to separate the various component parts of a UI application. Building UI applications without clear separation often leads to the inability to unit test the application, as a tester is required to drive a user interface. In this chapter we will show how to separate the various concerns to build a testable Web UI application.

**Getting started with Test Driven Development**

Using unit testing comprehensively within software development is a growing movement. Unit testing allows refactoring and maintenance with the confidence that existing functionality is not broken. In this module we will look at techniques for writing good unit tests and integrating them into testing frameworks to automate the unit tests. We will see that using the tests to drive the development guides you to produce flexible, loosely-coupled code with high test coverage.


**Designing code for testing**

Code is not inherently testable; it must be designed that way. In this module we look at common issues in code that make it hard to test and how we resolve them. Along the way we will look at Dependency Injection and Inversion of Control containers.


**Using Test Doubles to isolate code**

Loosely coupling is essential to being able to isolate the code under test - it allows us to provide alternate versions of, say, the data access layer. However, building alternate versions to cover every test scenario would be a significant overhead. Fortunately mocking frameworks come to our rescue, allowing us to create the test conditions "on-the-fly". In this module we look at how various types of test doubles (fakes, spies, stubs and mocks) can be used to isolate the code unit and how a mocking framework helps automate a lot of this work.

**Anti-Patterns**

An anti-pattern (or antipattern) is a pattern that may be commonly used but is ineffective and/or counterproductive in practice. This appendix describes developmental, architectural, and managerial anti-patterns. 
