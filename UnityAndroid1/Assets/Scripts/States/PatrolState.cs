using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public override void Enter(ref Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override void Execute(ref Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override void Exit(ref Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override bool OnMessage(ref Guard Entity)
    {
        throw new NotImplementedException();
    }
}
