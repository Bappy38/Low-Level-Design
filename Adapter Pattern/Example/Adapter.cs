﻿namespace Adapter_Pattern.Example;

/// <summary>
/// The Adapter makes the Adaptee's interface compatible with the Target's interface.
/// </summary>
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"This is {_adaptee.GetSpecificRequest()}";
    }
}
