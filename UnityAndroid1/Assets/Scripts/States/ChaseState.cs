﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State<GameObject>
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
