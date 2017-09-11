using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour {

    //Board and its size along horizontal/vertical
    public GameObject board;
    private float boardX;
    private float boardZ;

	// Use this for initialization
	void Start () {
        boardX = board.transform.localScale.x;
        boardZ = board.transform.localScale.z;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
