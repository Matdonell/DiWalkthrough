# Interception

Interception is a way of doing aspect oriented programming. It allows to intercept all calls to methods or properties of a class. 

One use would be to add retry code on external dependencies. If an external call fails, the interceptor could retry it a few times before giving up.

Another use would be to add telemetry to methods without any modification to the actual business logic code.