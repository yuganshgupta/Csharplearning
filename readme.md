# C# Learning

This repo contains the C# programs and small projects I am making while learning C# and .NET.

## Topics Covered

* C# program structure
* .NET, CLR, IL and JIT
* Value types and reference types
* Boxing and unboxing
* `var`, `object` and `dynamic`
* Strings and string interpolation
* Nullable types
* Null operators like `?.`, `??` and `??=`
* Type casting
* `Parse()` and `TryParse()`
* Pattern matching
* Properties
* Constructors and `this`
* Access modifiers
* Basic use of `base`
* Input validation
* Encapsulation
* Collections using `List<T>`, `Dictionary<TKey, TValue>` and `HashSet<T>`
* Generics
* `IEnumerable<T>` and basic iteration
* `GetEnumerator()` and how `foreach` works
* Visual Studio and Solution Explorer
* Basic `.csproj` structure
* AppSettings and JSON configuration
* `ConfigurationBuilder`
* Configuration sections and strongly typed settings
* Multiple configuration files and config overriding
* NLog logging
* Log levels, targets, rules and layouts
* Console and file logging
* Exception logging and stack traces
* JSON serialization and deserialization using Newtonsoft.Json
* Basic JSON file reading and writing
* Delegates and method references
* Passing delegates as parameters
* Reassigning a delegate to different methods
* Multicast delegates
* Adding and removing methods using `+=` and `-=`
* Nullable delegates and `?.Invoke()`
* Lambda expressions
* Expression lambdas and block lambdas
* Lambda parameter type inference
* Multiple-parameter lambdas
* Built-in delegates using `Func<>`
* Built-in delegates using `Action<>`
* LINQ fundamentals
* `Where()` for filtering
* `Select()` for transforming data
* LINQ method chaining
* Deferred execution
* Immediate execution using `ToList()`
* `First()` and `FirstOrDefault()`
* `Single()` and `SingleOrDefault()`
* `Any()` and `All()`
* `Count()`, `Sum()`, `Average()`, `Min()` and `Max()`
* `OrderBy()` and `OrderByDescending()`
* `ThenBy()` for secondary sorting
* `GroupBy()` and grouping keys
* `Join()` for combining related collections
* Anonymous objects in LINQ results
* `IEnumerable<T>` vs `IQueryable<T>`
* Basic use of `AsQueryable()`

## Practice Programs

* Var, Object and Dynamic
* Nullable Types
* Type Casting and Parsing
* Pattern Matching
* Properties
* User Input Validation
* Bank Account

## Projects

### Student Record Manager

A small console project I started while learning Collections.

Things implemented so far:

* Store students using `List<Student>`
* Add and display students
* Access students using indexes
* Remove students using `Remove()` and `RemoveAt()`
* Search students by ID using `foreach`
* Use `List.Find()` with a lambda for ID-based removal
* Basic validation while accessing and removing students

### Expense Tracker

Another small console project made to get more practice with Collections.

Things implemented so far:

* Store expenses using `List<Expense>`
* Add expenses
* Display all expenses
* Search expenses by ID
* Calculate the total expense using `foreach`
* Use `decimal` for expense amounts

### Contact Book

Small console project for practicing `Dictionary<TKey, TValue>`.

Things implemented so far:

* Store contacts using `Dictionary<string, string>`
* Add contacts
* Prevent duplicate names
* Display key-value pairs
* Search using `TryGetValue()`
* Update values using dictionary keys
* Remove contacts using keys

### Username Registry

Small console project for practicing `HashSet<T>`.

Things implemented so far:

* Store unique usernames using `HashSet<string>`
* Add usernames
* Prevent duplicate usernames
* Search usernames using `Contains()`
* Remove usernames using `Remove()`
* Display all stored usernames

### Generic Inventory

Small console project made while learning Generics and `IEnumerable<T>`.

Things implemented so far:

* Created a generic `Inventory<T>` class
* Stored items internally using `List<T>`
* Added items of different generic types
* Used `IEnumerable<T>` so the custom inventory can be iterated
* Used `GetEnumerator()` with the internal list
* Used `foreach` directly on the custom `Inventory<Product>`

### Config and AppSettings Demo

Small console project made while learning how configuration works in .NET.

Things implemented so far:

* Created `appsettings.json`
* Used `ConfigurationBuilder` to load configuration
* Used `GetSection()` to access grouped settings
* Used `Configuration.Binder` for strongly typed configuration
* Created an `AppSettings` class
* Used `Get<AppSettings>()` to bind JSON settings to a C# object
* Added multiple configuration files
* Used `appsettings.Local.json` to override settings from the main config
* Learned how JSON config files are copied to the build output directory
* Explored Visual Studio Solution Explorer, Dependencies and `.csproj`

### NLog Demo

Console project made while learning application logging using NLog.

Things implemented so far:

* Created loggers using `LogManager.GetCurrentClassLogger()`
* Used different log levels like `Trace`, `Debug`, `Info`, `Warn`, `Error` and `Fatal`
* Created logging rules to filter log levels
* Used a `ConsoleTarget` for console logging
* Used a `FileTarget` to save logs into a file
* Created custom log layouts
* Included timestamps, log levels and logger names in logs
* Logged exceptions with stack traces
* Configured NLog programmatically in C#
* Preserved the programmatic configuration as a separate example
* Moved logging configuration into `NLog.config`

### Newtonsoft JSON Demo

Console project made while learning JSON serialization and deserialization using Newtonsoft.Json.

Things implemented so far:

* Created a `Student` object and converted it into JSON
* Used `JsonConvert.SerializeObject()`
* Used `Formatting.Indented` for readable JSON
* Converted JSON back into a `Student` object using `DeserializeObject<T>()`
* Saved JSON data into a `.json` file
* Used `AppContext.BaseDirectory` to get the application's runtime directory
* Used `Path.Combine()` to create file paths
* Used `File.WriteAllText()` to save JSON data
* Used `File.ReadAllText()` to read JSON data back from a file

### Delegate Order Demo

Console project made while learning delegates, lambdas and built-in delegate types.

Things implemented so far:

* Created a `DiscountHandler` delegate for discount methods
* Created `NoDiscount`, `StudentDiscount` and `FestivalDiscount` methods
* Passed a delegate into `CalculateFinalPrice()` and invoked it there
* Reassigned the same delegate to different discount methods
* Created an `OrderHandler` delegate for order notifications
* Used a multicast delegate to run multiple notification methods from one call
* Added methods to the invocation list using `+=`
* Removed methods from the invocation list using `-=`
* Used a nullable delegate because removing handlers can leave the delegate with no methods
* Used `?.Invoke()` to safely invoke a nullable delegate
* Preserved the original named-method delegate demo in a separate file
* Used lambdas with the custom `DiscountHandler` delegate
* Practiced both block lambdas and expression lambdas
* Used multiple lambda parameters
* Replaced a custom delegate with `Func<decimal, decimal>`
* Used `Action<string>` for a lambda that returns `void`
* Compared custom delegates with `Func<>` and `Action<>`

### LINQ Demo

Console project made while learning LINQ and how queries work with collections.

Things implemented so far:

* Used `Where()` to filter values from a collection
* Compared manual `foreach` filtering with LINQ filtering
* Used `Select()` to transform values
* Chained `Where()` and `Select()` together
* Learned that LINQ queries can use deferred execution
* Tested deferred execution by modifying the original collection before enumeration
* Used `ToList()` to force immediate execution and create a snapshot
* Used `First()` and `FirstOrDefault()`
* Used `Single()` and `SingleOrDefault()`
* Used `Any()` and `All()` for boolean checks
* Used `Count()`, `Sum()`, `Average()`, `Min()` and `Max()`
* Used `OrderBy()` and `OrderByDescending()` for sorting
* Used `ThenBy()` for secondary sorting
* Created a `Student` model for object-based LINQ queries
* Used `GroupBy()` to group students by course
* Used `group.Key` to access the value used for grouping
* Used nested iteration to access objects inside LINQ groups
* Created `CourseInfo` data and joined it with students
* Used `Join()` with matching course keys from two collections
* Created anonymous objects containing values from both joined collections
* Compared `IEnumerable<T>` with `IQueryable<T>`
* Used `AsQueryable()` to practice working with an `IQueryable<Student>`
* Learned that the in-memory `AsQueryable()` demo does not involve SQL or a database
* Learned how `IQueryable<T>` becomes more useful with providers such as EF Core that can translate LINQ expressions into database queries
* LINQ query syntax using `from`, `where`, `orderby` and `select`

I will keep adding programs and small projects as I learn more C# and .NET.