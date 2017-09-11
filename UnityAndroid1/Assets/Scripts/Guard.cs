using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {

    StateMachine<Guard> FSM;

	// Use this for initialization
	void Start () {
        FSM = new StateMachine<Guard>();
	}
	
	// Update is called once per frame
	void Update () {
        FSM.UpdateState();
	}

    bool HandleMessage()
    {
        return false;
    }
}
