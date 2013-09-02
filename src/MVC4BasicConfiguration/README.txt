This solution sets up the basic layout of configuration with log4net with an MVC application

It wraps up the configuration logic into a LoggerConfig similar to how the base template wraps up Routing, Bundling, etc.
This LoggerConfig class will also delete all the old log files (older than 5 days old)

All messages get logged to a rolling file appender by date. 

Warnings and above get logged to the EventLog

A new global action filter has been implemented called HandleExceptionsAttribute that inherits from the HandleErrorAttribute.  The will log the exceptions to the Controller's logger.  See this StackOverflow question (http://stackoverflow.com/a/8712181/16149)

Added an extension method in the GenericObjectExtensions class that gets a log4net logger of the type of the instance calling the method.

Added a console example with a colored console appender

Added an instance based LogManager class that has a generic GetLogger method so I don't have to use typeof(Type)

Brought in an object rendering library called ObjectPrinter (https://github.com/drewburlingame/ObjectPrinter)
The documentation is wrong though, rendering class should use the ObjectPrinter.Log4Net dll name instead of the ObjectPrinter dll name.

