# Manual Dependenty injection
By using the constructor's parameters to receive different units of logic, the 
developer pushes units of logic into classes.

### The good
* Still easy to know what's going on
* Easy to unit test
* The use of interfaces is starting to make sense  
  The developer can inject different behaviors for a specified interface

### The bad

* Still hard to refactor
  * If the same instance of a dependency is to be used in nested dependency
  * When changing the arguments of the constructor(s)
  * Does not push to seperate state and logic