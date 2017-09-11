using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// With this class I want to assign waypoints along the board, like the way you would assign tiles to a 2D game with a board manager.
/// I will get the size of the board, then loop through the board, disregarding spaces taken up through the board (by gameobjects) and place waypoints for the guards to follow.
/// </summary>
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
