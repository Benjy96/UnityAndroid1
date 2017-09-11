using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {

    //Private:
    StateMachine<Guard> stateMachine;

    //Attributes
    private float speed;

    // Use this for initialization
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
