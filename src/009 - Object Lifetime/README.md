# Object lifetime

Lets begin with this question: who is responsible to dispose an object? A good answer might be the piece of code who instanciated it. When using dependency injection, you would never be responsible since the DI container is the one who initilizes the instances. That is why there are ways to create lifetime scopes, in which all disposable dependencies can be stored and managed. It then becomes easy to dispose all the objects created in a specific scope.

It is also possible to provide instances to the container that will be kept alive for the whole life of the container. This is a way of having a singleton pattern in DI.

##### To the next chapter
[010 - Open Generics](../010 - Open Generics)  