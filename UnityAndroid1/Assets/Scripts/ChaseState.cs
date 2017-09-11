using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : States<GameObject>
{
    private static ChaseState instance;
    private ChaseState() { }

    public static ChaseState GetSingleton()
    {
        if (instance == null)
        {
            instance = new ChaseState();

            return instance;
        }
        else
        {
            return instance;
        }
    }

    //PUBLIC INTERFACE

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
