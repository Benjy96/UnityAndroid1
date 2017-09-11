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

    //Construct & Initialize the FSM
    public StateMachine(entity_type owner) { this.owner = owner; }
    void SetCurrentState(State<entity_type> s) { currentState = s; }
    void SetPreviousState(State<entity_type> s) { previousState = s; }

    // ACCESSORS - READ ONLY//
    State<entity_type> CurrentState() { return currentState; }
    State<entity_type> PreviousState() { return previousState; }
    // ACCESSORS - READ ONLY//

    //Update the FSM
    public void UpdateState()
    {
        if (currentState != null)
        {
            currentState.Execute(owner);
        }
    }

    //Change to a new state
    public void ChangeState(State<entity_type> newState)
    {
        if (newState != null)
        {
            previousState = currentState;
            currentState.Exit(owner);
            currentState = newState;
            currentState.Enter(owner);
        }
        else
        {
            throw new System.Exception("Trying to switch to an invalid state");
        }
    }

    //Revert to previous state
    public void RevertToPreviousState()
    {
        ChangeState(previousState);
    }

    public bool HandleMessage()
    {
        return true;
    }
}
