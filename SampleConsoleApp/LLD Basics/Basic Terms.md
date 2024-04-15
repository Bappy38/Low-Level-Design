# OOAD in the SDLC

<p>The Software Development Life Cycle (SDLC) refers to the sequence of phases involved in software development. The stages of SDLC are shown below:</p>

```

Analysis -> Design -> Development -> Testing -> Verification -> Deployment

```

<p>The object-oriented analysis and design (OOAD) in SDLC allows one to analyze and design a system using object-oriented concepts and visualize each aspect of the OOAD process. In OOAD, we examine and inspect the entire system required for a particular problem, followed by identifying what it refers to as "objects" present in the system. It then establishes a relationship between the different objects and works on modeling and building a design for the whole system. The entire process is summarized in the following diagram:</p>

```

Observe the System -> Determine the objects -> Establish relationships between objects -> Model and Build the Design

```

<h3>Object-oriented analysis</h3>
<p>Object-oriented analysis is the method where the system requirements are identified, which are then used to create a model based on defining the roles of the objects present in the system and the tasks for which the system is responsible. The analysis step excludes any implementation details. Rather, we identify different use cases here.</p>

<h3>Object-oriented design</h3>
<p>Object-oriented design is the phase where the implementation of the defined requirements and the models created during the analysis phase begins. In this step, the models are further refined by adding additional constraints and making decisions such as adding new elements to the given initial structure. At this stage, the designer also goes into the inner details of the defined models and elaborates if any object-oriented principle is required. These models are usually built using Unified Modeling Language (UML) diagrams such as class or sequence diagrams which will be explained in detail in this chapter.</p>

<hr>

# Use Case Diagram

<h3>Components of a use case diagram</h3>

- **Actors:** Users are called actors. They interact with the system. They could be humans, machines/hardware, or other external systems. There are two types of actors:
	- **Primary Actors:** These are the humans or external systems that interact with that system and are responsible for initiating the use case. They are placed on the left side in a use case diagram. Primary actors are also called **Active Actors**
	- **Secondary Actors:** These are the ones that are used by the system to assist the primary actors in a use case. They cannot interact with the system on their own. They need primary actors to initiate a use case. Secondary actors are also called passive actors, and they are placed on the right side in a use case diagram.
- **Use Case:** This is a single function performed on a system by an actor. It is represented by an oval shape.
- **Package:** This is a group of different elements. These groups are represented inside a folder icon.
- **Note:** This is used to add additional information about any component or relationship in a use case diagram.

<h3>Relationships in use case diagrams:</h3>

There are four different types of relationships in a use case diagram:

- **Association:** This shows the relationship between and among actor(s) and use case(s). It represents how an actor can perform certain functions. It is denoted by a solid line without arrows. All the actors in a use case diagram must have at least one association with any use case. More than one actor can be associated with the same use case, and a single actor can be associated with more than one use case.
- **Generalization:** This relationship is also known as inheritance. In inheritance, we have parent and child classes. Similarly, in a use case diagram, we have parent and child use cases. The child use case has generalization with the parent use case. Each child inherits the behavior of its parent. It is denoted by a solid line with an arrow on only one side (toward the parent use case).
- **Include:** We use this to show the relationship between two use cases. It shows that one use cases includes the behavior of another use case. This included use case will execute only after the execution of the base use case. We can also say that the base use case requires an included use case in order to be completed. It is represented by a dashed line with an arrow on only one side (toward the included use case), and we write `<<include>>` above the line.
- **Extend:** We use this to show the relationship between two use cases. It shows that one use case extends the behaviors of another use case. The extended use case does not execute every time. It always depends on certain conditions. It is used to extend the functionality of the base use case. It is represented by a dashed line with an arrow on only one side (toward the base use case), and we write `<<extend>>` above the line.

<h3>Benefits of use case diagrams</h3>

- It explains the flow and objective of all use cases.
- It helps in understanding the high-level functional requirements of the system.
- It defines a system's context and needs.
- It explains the system behavior from a user perspective.
- It explains the scope of the system.

<hr>

# Class Diagram

<h3>Why use class diagrams?</h3>

- Represents the system's static structure.
- Directly maps with object-oriented languages.
- Represents what the system's duties or responsibilities are.
- Uses in both forward and reverse engineering.

<h3>Popular notations in the class diagram</h3>

- **Class Notation:** A class is represented by a rectangle with three sections. The first section holds the class name, the second one lists the attributes, and the third one shows the methods (operations).
- **Interface, Abstract Class and Enumeration:** We can declare a class as abstract using **abstract** keywords. The class name will be printed in italic. We can use the `<<abstract>>` `<<interface>>`, `<<annotation>>` and `<<enumeration>>` keywords too.
- **Access Modifiers:** You may use character symbols to specify the visibility of the associated object when defining methods or attributes. The most widely used access modifiers are as follows:
	- **Public:** A public member can be seen anywhere in the system. It is represented by a `+` symbol.
	- **Private:** Private members can only be accessible from within the class. It is inaccessible from outside the class. It is represented by a `-` symbol.
	- **Protected:** Protected members are only accessible within the class and derived classes. It is represented by the `#` symbol.

<h3>Association</h3>

**Association** provides a mechanism to communicate one object with another object, or one object provides services to another object. Association represents the relationship between classes.

The association can be divided into two categories. They are:

- Class Association (Inheritance)
	- Single Level Inheritance
	- Multi Level Inheritance
	- Hierarchical Inheritance
	- Multiple Inheritance
	- Hybrid Inheritance
- Object Association
	- Simple Association
	- Composition
	- Aggregation

<h3>Class Association</h3>

Inheritance falls under the category of class association. Creating a new class from the existing class (es) is called inheritance. Apart from its own behaviors and attributes, the child class inherits the characteristics of its parent(s). A solid line leads from the child class to the parent class with a hollow arrowhead representing the inheritcance relationship.


<h3>Object Association</h3>

Object Association (Relationship between objects) can be divided into the following categories:

- **Simple Association:** The weakest connections between objects are made through **Simple Association.** It is achieved through reference, which one object can inherit from another. For example, a `Person` named `Bappy` lives in a `House`.
- **Aggregation:** Aggregation describes the relationship between the container and the object it contains. An object may contain an aggregate of another object. Aggregation is denoted by a line with an unfilled diamond head towards the container. For example, a `Room` is a container. And `Table`, `Bed`, `Chair` are aggregate objects. These things can be shifted to another room and so can exist independently. **Aggregation is weaker relationship because:**
	- Aggregate objects are not a part of the container.
	- Aggregate objects can exist independently.
- **Composition:** An object may be composed of smaller objects, and the relationship between the `part` objects and the `whole` objects is known as **composition**.			
For example, the `Chair` class can be composed of other objects of `Arm`, `Seat` and `Leg`. COmposition is denoted by a line with a filled diamond head at the composer class pointing to the component class.
**Composition is a strong relationship because:**
	- The composed object becomes a part of the composer object.
	- Composed objects can not exist independently.

<h3>Some additional types of association</h3>

- Single-direction navigation is called **one-way association** and is denoted by an arrow toward the server object. For example, a `Person` named `Bappy` lives in a `House`. Here, `House` is the main object which is composed of a `Person` object.
- IF we navigate in both directions, the association is called a **two-way association** and is denoted by a line between two objects. For example, `Employee` works for `Company` and `Company` employs `Employee`s.
- Binary, ternary and n-ary associations are based on the number of objects.
	- Association in which two objects are involved is called a **binary association**. The binary association includes one-way or two-way navigation.
	- Association between the objects of exactly three classes is a **ternary association** and is denoted by a diamond with lines connected to associated objects.
	- Association between more than three classes is called **n-ary association**.


<h3>Dependency</h3>

**Dependency** indicates that one class is dependent on another class(es) for its implementation. Another class may or may not depend on the first class. A dashed arrow denotes dependency. For example, we have two classes - `RegistrationManager` and `Student`. The `RegistrationManager` class relies on the `Student` class for its behavior because the object of the `Student` class is passed as a parameter to one of the function in the `RegistrationManager` class.

<hr>

# Sequence Diagram


<h3></h3>
<p></p>

<h3></h3>
<p></p>

<hr>

# Activity Diagram

An **activity diagram** is a communication diagram that is used to show the dynamic aspects performed by a system. This diagram is used to represent a series of actions, similar to how they may appear in a flowchart.

<h3>Components of Activity Diagram</h3>

- **Initial:** This represents the start of the workflow of the activity diagram. They can be visualized as the node in a tree structure.
- **Action:** These are the main building block of an activity diagram and are used to show the activities that a modeled process is made of.
- **Flow Final:** This represents the end of a single path in the activity diagram. They can be visualized as a leaf in a tree structure.
- **Activity Final:** This represents the end of all the activities in the activity diagram.
- **Control Flow:** This shows the directional flow of the diagram. This exists as a connector between one action and another.
- **Object Flow:** This shows the path of the objects as they move throughout the activity.
- **Decision:** This is used to represent multiple options that are possible in a system. They appear as a branch alongside the text describing the condition for the path.
- **Merge:** This uses the same symbol as a decision. However, this shows that multiple options join at this node, but leads to a single output.
- **Fork and Join:** The fork node represents a single activity that is split into two concurrent activities happening alongside each other. On the other hand, the join nodes joins two concurrent activities together to lead to a single activity.

<h3></h3>
<p></p>

<h3></h3>
<p></p>