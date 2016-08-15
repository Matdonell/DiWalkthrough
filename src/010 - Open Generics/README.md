# Open Generics

Most DI containers allows for registrations of open generics. An open generic would be List<> without its generic type argument supplied. 
This is useful when developing tools. 
In this example, we show an example of a strongly typed command dispatcher. 
A useful scenario is when you are developing tools that needs to cache data or execution plans by type. 
Generic type's static fields are static by generic type (for example, if List\<int> and List\<string> had a static property, there would be two static properties).

[011 - Unit Testing](../011 - Unit Testing)  