**Last Read at 3.5.2024**

# Intent

<p><b>Observer</b> is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they are observing.</p>

<p>It enables multiple objects to subscribe to another object and get notified when an event occurs to this observed object. So, on one hand, we have a Provider (sometimes called a Subject or a Publisher) which is the observed object. An Observer can subscribe to a Provider and get notified whenever a predefined condition happens. This predefined condition is usually an event or a state change.</p>

# Problem

<p>Imagine, that you have two types of object: a Customer and a Store. The customer is very interested in a particular brand of product. The customer could visit the store every day and check that product availability. But while the product is still in route, most of these round trips would be pointless.</p>

<p>On the other hand, the store could send tons of emails (which might be considered spam) to all customers each time a new product becomes available. This would save some customers from endless trips to the store. At the same time, it would upset other customers who aren't interested in that new product.</p>

# Solution

<p>The Observer pattern suggests that you add a subscription mechanism to the Publisher class so individual objects can subscribe to or unsubscibe from a stream of events coming from that publisher. In reality, this mechanism consists of:</p>

<ol>
	<li>An array field for storing a list of references to subscriber object.</li>
	<li>Several public methods which allow adding subscribers to and removing them from that list.</li>
</ol>

<p>Now, whenever an important event happens to the publisher, it goes over its subscribers and calls the specific notification method on their objects.</p>

<p>Real apps might have dozens of different subscriber classes that are interested in tracking events of the same publisher class. Besides, you might not even know about some of them beforehand if your publisher class is supposed to be used by other people.</p>

<p>That's why it's crucial that all subscribers implement the same interface and the publisher communicates with them only via that interface. This interface should declare the notification method along with a set of parameters that the publisher can use to pass some contextual data along with the notification.</p>

<p>IF your app has several different types of publisher and you want to make your subscriber compatible with all of them, you can go even further and make all publishers follow the same interface. This interface would only need to describe a few subscription methods. The interface would allow subscribers to observe publisher's states without coupling to their concrete classes.</p>

# Structure

<ol>
	<li>The <b>Publisher</b> issues events of interest to other objects. These events occur when the publisher changes its state or executes some behaviors. Publishers contain a subscription infrastructure that lets new subscribers join and current subscribers leave the list.</li>
	<li>When a new event happens, the publisher goes over the subscription list and calls the notification method declared in the subscriber interface on each subscriber object.</li>
	<li>The <b>Subscriber</b> interface declares the notification interface. In most cases, it consists of a single update method. The method may have several parameters that let the publisher pass some event details along with the update.</li>
	<li><b>Concrete Subscribers</c> perform some actions in response to notifications issued by the publisher. All of these classes must implement the same interface so the publisher isn’t coupled to concrete classes.</li>
	<li>Usually, subscribers need some contextual information to handle the update correctly. For this reason, publishers often pass some context data as arguments of the notification method. The publisher can pass itself as an argument, letting subscriber fetch any required data directly.</li>
	<li>The Client creates publisher and subscriber objects separately and then registers subscribers for publisher updates.</li>
</ol>

# Applicability

<ol>
	<li>Use the Observer pattern when changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.</li>
	<li>Use the pattern when some objects in your app must observe others, but only for a limited time or in specific cases.</li>
</ol>

# How to Implement

<ol>
	<li>Look over your business logic and try to break it down into two parts: the core functionality, independent from other code, will act as the publisher; the rest will turn into a set of subscriber classes.</li>
	<li>Declare the subscriber interface. At a bare minimum, it should declare a single update method.</li>
	<li>Declare the publisher interface and describe a pair of methods for adding a subscriber object to and removing it from the list. Remember that publishers must work with subscribers only via the subscriber interface.</li>
	<li>Decide where to put the actual subscription list and the implementation of subscription methods. Usually, this code looks the same for all types of publishers, so the obvious place to put it is in an abstract class derived directly from the publisher interface. Concrete publishers extend that class, inheriting the subscription behavior.</li>
	<li>Create concrete publisher classes. Each time something important happens inside a publisher, it must notify all its subscribers.</li>
	<li>Implement the update notification methods in concrete subscriber classes. Most subscribers would need some context data about the event. It can be passed as an argument of the notification method.<br>But there’s another option. Upon receiving a notification, the subscriber can fetch any data directly from the notification. In this case, the publisher must pass itself via the update method. The less flexible option is to link a publisher to the subscriber permanently via the constructor.</li>
	<li>The client must create all necessary subscribers and register them with proper publishers.</li>
</ol>

# Pros

<ol>
	<li>Open/Closed Principle: You can introduce new subscriber classes without having to change the publisher's code.</li>
	<li>You can establish relation between object at Runtime.</li>
</ol>

# Cons

<ol>
	<li>Subscribers are notified in random order.</li>
</ol>

# Relations with Other Pattern

<ul>
	<li>Chain of Responsibility passes a request sequentially along a dynamic chain of potential receivers until one of them handles it.</li>
	<li>Command establishes unidirectional connections between senders and receivers.</li>
	<li>Mediator eliminates direct connections between senders and receivers, forcing them to communicate indirectly via a mediator object.</li>
	<li>Observer lets receivers dynamically subscribe to and unsubscribe from receiving request.</li>
</ul>

<p>The difference between Mediator and Observer is often elusive. In most cases, you can implement either of these patterns. But sometimes you can apply both simultaneously.</p>

<p>The primary goal of Mediator is to eliminate mutual dependencies among a set of system components. Instead, these components become dependent on a single mediator object. The goal of Observer is to establish dynamic one-way connection between objects, where some object acts as subordinates of others.</p>

<p>There's a popular implementation of Mediator pattern that relies on Observer. The mediator object plays the role of publisher, and the components acts as subscribers which subscribe to and unsubscribe from the mediator's events. When Mediator is implemented this way, it may look similar to Observer.</p>

<p>When you’re confused, remember that you can implement the Mediator pattern in other ways. For example, you can permanently link all the components to the same mediator object. This implementation won’t resemble Observer but will still be an instance of the Mediator pattern.
</p>

# Resource

<ul>
	<li><a href="https://refactoring.guru/design-patterns/observer">Refactoring GURU</a></li>
	<li><a href="https://code-maze.com/csharp-observer-design-pattern/">Code-Maze</a></li>
	<li><a href=""></a></li>
</ul>