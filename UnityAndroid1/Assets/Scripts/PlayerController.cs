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
		
	}

    private void MoveInDirection()
    {
        //TODO: Implement a navmesh move method (will auto-pathfind)
    }
}
