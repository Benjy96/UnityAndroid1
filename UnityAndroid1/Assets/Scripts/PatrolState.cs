using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : States<GameObject> {

    static PatrolState Singleton()
    {
        PatrolState instance = new PatrolState();

        return instance;
    }

    private PatrolState()
    {

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
