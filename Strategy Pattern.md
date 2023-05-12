<b>Strategy is a behavioral design patterns that turns a set of behaviors into objects and make them interchangeable inside original context object.</b>

<b>In other words, we have a main Context object that holds a reference towards a Strategy object and delegates it by executing its functionality. IF we want to change the way the Context perform its work, we can just replace the current Strategy object with another one.</b>

<p>Strategy pattern compiles with the rules of Open Closed principle.</p>

<p><b>Usage examples:</b> The Strategy pattern is very common in C# code. It's often used in various frameworks to provide users a way to change the behavior of a class without extending it. In other word, we should use this pattern whenever we have different variations for some functionality in an object and we want to switch from one variation to another in runtime. Furthermore, if we have similar classes in our project that only differ on how they execute some behavior, the Strategy pattern should be the right choice for us.</p>

<p><b>Identification:</b> Strategy pattern can be recognized by a method that lets a nested object do the actual work, as well as a setter that allows replacing that object with a different one.</p>