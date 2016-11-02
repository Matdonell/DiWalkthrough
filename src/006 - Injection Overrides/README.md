# Dependency overrides

Without dependency overrides, it would be very difficult to alter the default resolving behavior. A dependency override is used to supply a specific instance as the dependency. This becomes useful when you want to swap implementation based on configuration. For example, you could have a Logger that logs to a file and a logger that logs to a log stream for debugging purposes.

A dependency override should be used when the logic needs to be altered on a full dependency graph.

##### To the next chapter
[007 - Class Hierarchies](../007 - Class Hierarchies)  