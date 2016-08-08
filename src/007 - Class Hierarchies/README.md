# Class Hierarchies

A registration does not always register a type as itself. It is possible to register type as itself, one of its parents or implemented interfaces. 

By doing this, it becomes very easy to unit test the logic of a class by providing mocks as dependencies of the class.

It also allows you to make multiple registrations for one give key and then later resolve multiple dependencies for that key.

##### To the next chapter
[008 - Inversion of Control](../008 - Inversion of Control)  