**Last Read at 15.07.2024**

# Definition

<b>Builder is a creational design pattern, which allows constructing complex objects step by steps</b>

# Usage Example

<b>The Builder Pattern is a well known pattern in C# world. It's specially useful when you need to create an object with lots of possible configuration options.</b>

# Identification

<p>The Builder Pattern can be recognized in a class, which has a single creation method and several methods to configure the resulting object. Builder method often support chaining (for example, someBuilder.setValueA(1).setValueB(2).setValueC(3).create())</p>

# Participants

<p>The classes and objects participating in this pattern include:</p>

<b>Builder</b>

<ul>
	<li>Specifies an abstract interface for creating parts of a Product object.</li>
</ul>

<b>ConcreteBuilder</b>

<ul>
	<li>Constructs and assembles parts of the product by implementing the Builder interface.</li>
	<li>Defines and keeps track of the representation it creates.</li>
	<li>Provides an interface for retrieving the product.</li>
</ul>

<b>Director</b>

<ul>
	<li>Constructs an object using the Builder interface.</li>
</ul>

<b>Product</b>

<ul>
	<li>Represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled.</li>
	<li>Includes classes that define the constituent parts, including interfaces for assembling the parts into the final result.</li>
</ul>

# Reference

<ul>
	<li><a href="https://code-maze.com/builder-design-pattern/">Code-Maze</a></li>
	<li><a href="https://www.dofactory.com/net/builder-design-pattern">Do Factory</a></li>
</ul>