using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// State base class
/// </summary>
/// <typeparam name="entity_type">The entity which will be using the states. Means each method here can access public interface of the caller. e.g. if Guard calls execute, the execute can do entity.x();</typeparam>
public abstract class State<entity_type>
{
    public abstract void Enter(entity_type Entity);

    public abstract void Execute(entity_type Entity);

    public abstract void Exit(entity_type Entity);

    public abstract bool OnMessage(entity_type Entity);
}
