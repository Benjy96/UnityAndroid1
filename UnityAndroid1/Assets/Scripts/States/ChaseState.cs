using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SINGLETON - One shared state instance.
/// Guard owned state for chasing the player. (Navmesh?)
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
        //Turn to face player - Set flashlight color to red, and send a message to nearby guards
        //IF ALERTED BY NEARBY GUARD - Turn to face the player, but DON'T send message to nearby (or it'd alert everyone - maybe for higher difficulty this would be good)
        throw new NotImplementedException();
    }

    public override void Execute(Guard Entity)
    {
        //End game if the player is sighted for more than a set period of time
        //ADVANCED (DO AFTER ALL DONE) -Disregard waypoint path and follow the player (navmesh?)
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
