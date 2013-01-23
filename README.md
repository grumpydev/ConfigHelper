ConfigHelper
============

Config helper class for loading a config from file if it exists.

The idea being that you have a config class with some defaults (localhost, password for passwords etc), then load the config from a file on startup and add that filename to the gitignore. That way anyone grabbing your code can (hopefully) just run and go, but on the production box you have a config file with differen settings (connection strings etc).
