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

    //Go to nearest waypoint
    private void FollowWaypoints()
    {
        //Get current position and compare to that of a waypoint array
        //Follow the path in terms of incrementing along the index of waypoints
        //Board manager should spawn in all objects from the same array, randomly choosing where to put what
        //Guard can then loop through array to follow, and move to the next point (if) it has tag of "Waypoint"
        //Potential problem - blocked by a wall - solution? Move down a dimension of the array (i.e. TURN)
    }

}
