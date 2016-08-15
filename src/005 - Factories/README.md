# Factories

Most DI contains allows the use of factories. Some allows for more evolved factories like Autofac and others like Unity allows for simple parameterless factories.

A factory is used to get a new instance of a class without using the Service Locator pattern. When used within pre-defined scopes, context aware dependency injection can be used.

A factory can be used when you have a stateful class that contains logic. If you need to do multiple operations on a unit of logic before getting the result, a specific instance needs to be used until a new unit of work is started.

##### To the next chapter
[006 - Injection Overrides](../006 - Injection Overrides)  
