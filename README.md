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

[001 - Before DI](src/001 - Before DI)  
[002 - Manual DI](src/002 - Manual DI)  
[003 - DI Framework](src/003 - DI Framework)  
[004 - Injection Points](src/004 - Injection Points)  
[005 - Factories](src/005 - Factories)  
[006 - Injection Overrides](src/006 - Injection Overrides)  
[007 - Class Hierarchies](src/007 - Class Hierarchies)  
[008 - Inversion of Control](src/008 - Inversion of Control)  
[009 - Object Lifetime](src/009 - Object Lifetime)  
[010 - Open Generics](src/010 - Open Generics)  
[011 - Unit Testing](src/011 - Unit Testing)  
[012 - Interception](src/012 - Interception)  