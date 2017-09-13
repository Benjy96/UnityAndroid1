using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Add mobile controls: tap point to move to it
// TODO: Add pc controls: mouse click to move to point
public class PlayerController : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
    #if UNITY_STANDALONE || UNITY_WEBPLAYER
        // TODO: Implement PC Code
    #else
        // TODO: Implement Mobile Code
    #endif
    }

    private void MoveInDirection()
    {
        //TODO: Implement a navmesh move method (will auto-pathfind)
    }
}
