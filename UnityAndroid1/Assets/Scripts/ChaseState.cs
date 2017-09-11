using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : States<GameObject>
{
    
    static ChaseState Singleton()
    {
        ChaseState instance = new ChaseState();

        return instance;
    }

    private ChaseState()
    {

    }

    public override void Enter(GameObject Entity)
    {
        throw new NotImplementedException();
    }

    public override void Execute(GameObject Entity)
    {
        throw new NotImplementedException();
    }

    public override void Exit(GameObject Entity)
    {
        throw new NotImplementedException();
    }

    public override bool OnMessage(GameObject Entity)
    {
        throw new NotImplementedException();
    }
}
