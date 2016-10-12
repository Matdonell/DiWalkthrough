# Injection points

## Constructors
Constructor injection is the most common way of doing dependency injection.

### The good
* Easy to force read-only dependencies
* All DI frameworks support it
* Forces unit tests to supply all dependencies
* Clear definition of required dependencies
* If used in libraries, makes them DI ready.

### The bad
* Forces to write boilerplate code in the constructor to assign private members
* Forces a lot of code to unit test  
  The developer is required to build all the dependencies in advance, even if not required

## Properties
Property injection is supported in multiple frameworks like Unity, MEF, Autofac, etc... 

### The good
* Less boilerplate code in each class
* Less boilerplate code in unit tests

### The bad
* Harder to discover required dependencies
* Initial unit tests failure happens at runtime instead of compile time when changing a class
* Outside world can alter your dependencies
* Requires good team work and clear process to avoid "The bad"

##### To the next chapter
[005 - Factories](../005 - Factories)  