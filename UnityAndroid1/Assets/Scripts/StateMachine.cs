using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Finite State Machine manages the states of an agent/entity (does it FOR them - abstraction/separation).
/// Agent just needs to own a StateMachine instance. (Composition)
/// The generics mean we can reuse this class. E.g. Any called state will have access to public interface of the object. E.g. spotlight attribute on a guard passed in with execute method. Owner.spotlight.
/// 
/// UML:
/// Finite state machine    HAS attributes (in this case, states) that it manages
/// 
/// Theory of Finite State Machine: 
/// FSM manages states. Stores these as "data" to be modified, which happens via an agent's states calling a method such as ChangeState();
/// </summary>
/// <typeparam name="entity_type">The object that owns this statemachine</typeparam>
public class StateMachine<entity_type> {

    private entity_type owner;  //If guard, you get access to guard methods in this variable, if was a special type of guard, access to its stuff
    private State<entity_type> currentState;
    private State<entity_type> previousState;

    //PUBLIC INTERFACE

    //Construct & Initialize the FSM
    public StateMachine(entity_type owner) { this.owner = owner; }
    public void SetCurrentState(State<entity_type> s) { currentState = s; }
    public void SetPreviousState(State<entity_type> s) { previousState = s; }

    // ACCESSORS - READ ONLY//
    State<entity_type> CurrentState() { return currentState; }
    State<entity_type> PreviousState() { return previousState; }
    // ACCESSORS - READ ONLY//

    //Update the FSM
    public void UpdateState()
    {
        if (currentState != null)
        {
            currentState.Execute(owner);    //owner variable means that states can access public methods (e.g. to modify attributes)
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
