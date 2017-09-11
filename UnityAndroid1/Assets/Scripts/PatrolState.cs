using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : States<GameObject> {

    private static PatrolState instance;
    private PatrolState() {}

    public static PatrolState Singleton()
    {
        if(instance == null)
        {
            instance = new PatrolState();

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
