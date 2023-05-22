# Intro

<b>The Composite design pattern is a structural design pattern that allows us to compose objects into a tree structure and then work with that structure as if it is a single object. That also means using this design pattern makes sense when the part of our app can be represented as a tree.</b>

# Structure

<p>Composite design pattern consists of the following parts:</p>

<ul>
	<li><b>Component</b> is an interface that describe the operations that are common to either simple(leaf) or complex(non-leaf) elements of the tree.</li>
	<li><b>Leaf</b> is a single object, that doesn't have sub-elements. Our tree structure consists of more leaf objects.</li>
	<li><b>Composite</b> is an object that does have sub-elements (leaves or other composite objects). Interesting thing is that the Composite object isn't familiar with the concrete classes of its children. It communicates with its children via the Component interface.</li>
</ul>

<p>Finally, we have a client, which works with all the elements through the Component interface.</p>