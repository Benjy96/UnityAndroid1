using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State<GameObject> {

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

    public override void Enter(ref GameObject Entity)
    {
        throw new NotImplementedException();
    }

    public override void Execute(ref GameObject Entity)
    {
        throw new NotImplementedException();
    }

    public override void Exit(ref GameObject Entity)
    {
        throw new NotImplementedException();
    }

    public override bool OnMessage(ref GameObject Entity)
    {
        throw new NotImplementedException();
    }
}
