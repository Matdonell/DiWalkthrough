# Dependenty injection Frameworks
By using dependency injection framework(s) (usualy 1 at a time!) comes quite a few advantages. But, there will also be costs like adding complexity.

### The good
* Easy to unit test
* The use of interfaces makes sense  
  The developer can inject different behaviors for a specified interface
* Easy to refactor since none of the constructors are directly used. Adding or removing a dependency now has almost no cost
* Easy to make really small units of logic and resolve them  
  Even though the number of dependencies is going to go up really fast, it is not a big issue as the required code to initialize those dependencies is minimal (constructor parameter or injected property) 
* Pushes the developer to seperate the logic and the data (sorry for promoting functionnal programming :P)

### The bad

* Harder to know what's going on  
  Harder to know why one dependency and not an other is used
* A small performance hit when resolving units of logic