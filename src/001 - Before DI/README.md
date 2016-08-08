# Before Dependenty injection
The common way of initializing dependencies is to "new" them when you need it. 
You decide exactly which implementation will be used.

### The good
* Easy to know what's going on

### The bad
* Hard to unit test
* Hard to refactor
  * If the same instance of a dependency is to be used in nested dependency
  * When changing the arguments of the constructor(s)
  * Does not push to use interfaces
  * Does not push to seperate state and logic

##### To the next chapter
[002 - Manual DI](../002 - Manual DI)  