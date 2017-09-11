using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SINGLETON - Guard owned state
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
        //if can see player: chase
        //if CANNOT see player, patrol
    }

    public override void Exit(Guard Entity)
    {
        throw new NotImplementedException();
    }

    public override bool OnMessage(Guard Entity)
    {
        throw new NotImplementedException();
    }

    //Private Implementation
    private bool CanSeePlayer()
    {
        return false;
    }

    private void FollowWaypoints()
    {

    }

}
