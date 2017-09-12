using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// State base class. Generic allows any entity to subclass.
/// </summary>
/// <typeparam name="entity_type">The type of entity which will own subclasses states.</typeparam>
public abstract class State<entity_type>
{
    public abstract void Enter(entity_type Entity);

    public abstract void Execute(entity_type Entity);

    public abstract void Exit(entity_type Entity);

    public abstract bool OnMessage(entity_type Entity);
}
