using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// State base class
/// </summary>
/// <typeparam name="T">The entity which will be using the states</typeparam>
public abstract class State<T>
{
    public abstract void Enter(ref T Entity);

    public abstract void Execute(ref T Entity);

    public abstract void Exit(ref T Entity);

    public abstract bool OnMessage(ref T Entity);
}
