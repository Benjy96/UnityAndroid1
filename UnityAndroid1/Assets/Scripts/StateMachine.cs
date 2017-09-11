using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class provides some abstraction.
/// The Finite State Machine manages the states of an agent/entity.
/// </summary>
/// <typeparam name="entity_type"></typeparam>
public class StateMachine<entity_type> {

    private entity_type owner;
    private State<entity_type> currentState;
    private State<entity_type> previousState;

    //PUBLIC INTERFACE

    public StateMachine(entity_type owner)
    {
        this.owner = owner;
    }

    void SetCurrentState(State<entity_type> s) { currentState = s; }
    void SetPreviousState(State<entity_type> s) { previousState = s; }

    public void UpdateState()
    {
        if (currentState != null)
        {
            currentState.Execute(owner);
        }
    }

    public void ChangeState(entity_type Entity)
    {

    }

    public bool HandleMessage()
    {
        return true;
    }
}
