using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {
    
    //Instance of a Finite State Machine
    StateMachine<Guard> stateMachine;

    //Attributes
    private float speed;

    //This will hold the vector that the guard spawns on - need to locate the nearest waypoint
    private int placeInSpawnArray;

    //Initialize a finite state machine
    void Start () {
        stateMachine = new StateMachine<Guard>(this);
        stateMachine.SetCurrentState(PatrolState.GetSingleton());
	}
	
	// Update is called once per frame
	void Update () {
        stateMachine.UpdateState();
	}

    bool HandleMessage()
    {
        return false;
    }
}
