# DiWalkthrough
Is meant people who wants to know more about Dependency Injection.

## Some information

### What is Dependency Injection
In software engineering, dependency injection is a software design pattern that implements inversion of control for resolving dependencies. A dependency is an object that can be used (a service). An injection is the passing of a dependency to a dependent object (a client) that would use it.

### What is Inversion Of Control
Inversion of control (IoC) is a programming technique, expressed here in terms of object-oriented programming, in which object coupling is bound at run time by an assembler object and is typically not known at compile time using static analysis.

### What did we gain from it
Here's a few good things that came out of it: 
* Easier to replace static methods by instances (don't need to instanciate tools by hand)
* Easier to do unit tests (try to unit test a method that uses a chain of static methods)
* Less boilerplate code (No more 'new'ing utilities)
* Use of interception

## Chapters

[001 - Before DI](src/001 - Before DI/README.md)  
[002 - Manual DI](src/001 - Manual DI/README.md)  
[003 - DI Framework](src/001 - DI Framework/README.md)  
[004 - Injection Points](src/001 - Injection Points/README.md)  
[005 - Injection Overrides](src/001 - Injection Overrides/README.md)  
[006 - Object Lifetime](src/001 - Object Lifetime/README.md)  
[007 - Class Hierarchies](src/001 - Class Hierarchies/README.md)  
[008 - Inversion of Control](src/001 - Inversion of Control/README.md)  
[009 - Unit Testing](src/001 - Unit Testing/README.md)  
[010 - Open Generics](src/001 - Open Generics/README.md)  
