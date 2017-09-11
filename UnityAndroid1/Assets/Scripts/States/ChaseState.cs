using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SINGLETON - Guard owned state
/// </summary>
public class ChaseState : State<Guard>
{
    private static ChaseState instance;
    private ChaseState() { }

    //PUBLIC INTERFACE

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

    public override void Enter(Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override void Execute(Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override void Exit(Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override bool OnMessage(Guard Entity)
    {
        throw new NotImplementedException();
    }
}
