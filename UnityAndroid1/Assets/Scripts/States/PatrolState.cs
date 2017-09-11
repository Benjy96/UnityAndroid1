using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Guard owned state
/// </summary>
public class PatrolState : State<Guard> {

    private static PatrolState instance;
    private PatrolState() {}

    //PUBLIC INTERFACE

    public static PatrolState GetSingleton()
    {
        if (instance == null)
        {
            instance = new PatrolState();

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
