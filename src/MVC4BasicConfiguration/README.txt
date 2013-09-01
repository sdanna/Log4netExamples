This solution sets up the basic layout of configuration with log4net with an MVC application

It wraps up the configuration logic into a LoggerConfig similar to how the base template wraps up Routing, Bundling, etc.
This LoggerConfig class will also delete all the old log files (older than 5 days old)

All messages get logged to a rolling file appender by date. 

Warnings and above get logged to the EventLog