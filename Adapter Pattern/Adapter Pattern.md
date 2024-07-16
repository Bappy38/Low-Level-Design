**Last Read at 15.07.2024**

# Definition

<p>Adapter is a structural design pattern, which allows incompatible objects to collaborate. The Adapter acts as a wrapper between two objects. It catches call from one object and transforms them to format and interface recognizable by the second object.</p>

# Usage Example

<p>It's very often used in system based on some legacy code. In such cases, Adapters make legacy code with modern classes.</p>

# Identification

<p>Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type. When the adapter receives a call to any of its  methods, it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.</p>

<b>Adapter is kind of an interceptor/middleware.</b>