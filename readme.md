C# Learning

This repo contains the C# programs and small projects I am making while learning C# and .NET.

Topics Covered

C# program structure

.NET, CLR, IL and JIT

Value types and reference types

Boxing and unboxing

var, object and dynamic

Strings and string interpolation

Nullable types

Null operators like ?., ?? and ??=

Type casting

Parse() and TryParse()

Pattern matching

Properties

Constructors and this

Access modifiers

Basic use of base

Input validation

Encapsulation

Collections using List<T>, Dictionary<TKey, TValue> and HashSet<T>

Generics

IEnumerable<T> and basic iteration

GetEnumerator() and how foreach works

Visual Studio and Solution Explorer

Basic .csproj structure

AppSettings and JSON configuration

ConfigurationBuilder

Configuration sections and strongly typed settings

Multiple configuration files and config overriding

NLog logging

Log levels, targets, rules and layouts

Console and file logging

Exception logging and stack traces

JSON serialization and deserialization using Newtonsoft.Json

Basic JSON file reading and writing

Practice Programs

Var, Object and Dynamic

Nullable Types

Type Casting and Parsing

Pattern Matching

Properties

User Input Validation

Bank Account

Projects

Student Record Manager

A small console project I started while learning Collections.

Things implemented so far:

Store students using List<Student>

Add and display students

Access students using indexes

Remove students using Remove() and RemoveAt()

Search students by ID using foreach

Use List.Find() with a lambda for ID-based removal

Basic validation while accessing and removing students

Expense Tracker

Another small console project made to get more practice with Collections.

Things implemented so far:

Store expenses using List<Expense>

Add expenses

Display all expenses

Search expenses by ID

Calculate the total expense using foreach

Use decimal for expense amounts

Contact Book

Small console project for practicing Dictionary<TKey, TValue>.

Things implemented so far:

Store contacts using Dictionary<string, string>

Add contacts

Prevent duplicate names

Display key-value pairs

Search using TryGetValue()

Update values using dictionary keys

Remove contacts using keys

Username Registry

Small console project for practicing HashSet<T>.

Things implemented so far:

Store unique usernames using HashSet<string>

Add usernames

Prevent duplicate usernames

Search usernames using Contains()

Remove usernames using Remove()

Display all stored usernames

Generic Inventory

Small console project made while learning Generics and IEnumerable<T>.

Things implemented so far:

Created a generic Inventory<T> class

Stored items internally using List<T>

Added items of different generic types

Used IEnumerable<T> so the custom inventory can be iterated

Used GetEnumerator() with the internal list

Used foreach directly on the custom Inventory<Product>

Config and AppSettings Demo

Small console project made while learning how configuration works in .NET.

Things implemented so far:

Created appsettings.json

Used ConfigurationBuilder to load configuration

Used GetSection() to access grouped settings

Used Configuration.Binder for strongly typed configuration

Created an AppSettings class

Used Get<AppSettings>() to bind JSON settings to a C# object

Added multiple configuration files

Used appsettings.Local.json to override settings from the main config

Learned how JSON config files are copied to the build output directory

Explored Visual Studio Solution Explorer, Dependencies and .csproj

NLog Demo

Console project made while learning application logging using NLog.

Things implemented so far:

Created loggers using LogManager.GetCurrentClassLogger()

Used different log levels like Trace, Debug, Info, Warn, Error and Fatal

Created logging rules to filter log levels

Used a ConsoleTarget for console logging

Used a FileTarget to save logs into a file

Created custom log layouts

Included timestamps, log levels and logger names in logs

Logged exceptions with stack traces

Configured NLog programmatically in C#

Preserved the programmatic configuration as a separate example

Moved logging configuration into NLog.config

Newtonsoft JSON Demo

Console project made while learning JSON serialization and deserialization using Newtonsoft.Json.

Things implemented so far:

Created a Student object and converted it into JSON

Used JsonConvert.SerializeObject()

Used Formatting.Indented for readable JSON

Converted JSON back into a Student object using DeserializeObject<T>()

Saved JSON data into a .json file

Used AppContext.BaseDirectory to get the application's runtime directory

Used Path.Combine() to create file paths

Used File.WriteAllText() to save JSON data

Used File.ReadAllText() to read JSON data back from a file

I will keep adding programs and small projects as I learn more C# and .NET.
