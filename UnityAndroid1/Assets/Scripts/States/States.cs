using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class States<T> {

    public abstract void Enter(T Entity);

    public abstract void Execute(T Entity);

    public abstract void Exit(T Entity);

    public abstract bool OnMessage(T Entity);
}
