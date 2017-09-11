using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {



	// Use this for initialization
	void Start () {
        StateMachine<Guard> FSM = new StateMachine<Guard>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    bool HandleMessage()
    {
        return false;
    }
}
