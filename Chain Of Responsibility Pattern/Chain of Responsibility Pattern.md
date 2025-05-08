**Last Read at 05.08.2025**

# Intro

<b>Chain of Responsibility is behavioral design pattern that allows passing request along the chain of potential handlers until one of them handles request.</b>

<p>The pattern allows multiple objects to handle the request without coupling sender class to the concrete classes of the receivers. The chain can be composed dynamically at runtime with any handler that follows a standard handler interface.</p>

# Identification

<p>The pattern is recognizable by behavioral methods of one group of objects that indirectly call the same methods in other objects, while all the object follow the common interface.</p>

# Advantages

- **Decoupling of Objects:** The pattern makes enables sending a request to a series of possible recipients without having to worry about which object will handle it in the end. This lessens the reliance between items.
- **Flexibility and Extensibility:** New handlers can be added or existing ones can be modified without affecting the client code. This promotes flexibility and extensibility within the system.
- **Dynamic Order of Handling:** The sequence and order of handling requests can be changed dynamically during runtime, which allows adjustment of the processing logic as per the requirements.
- **Simplified Object Interaction:** It simplifies the interaction between the sender and receiver object, as the sender doesn't need to know the processing logic.
- **Enhanced Maintainability:** Each handler performs a specific type of processing, which making maintaining and modifying the individual components easier without impacting the overall system.

# Disadvantages

- **Possible Unhandled Requests:**
- **Performance Overhead:**
- **Complexity in Debugging:**
- **Runtime Configuration Overhead:**


# Resource Link

<ul>
	<li><a href="https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example">Refactoring GURU</a></li>
</ul>