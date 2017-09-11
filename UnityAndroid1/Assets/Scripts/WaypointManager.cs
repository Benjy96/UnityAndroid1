﻿using System.Collections;
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

    //Waypoint Holder
    public Transform pathHolder;
    //Waypoint prefab
    public Transform waypoint;

	void Start () {
        //Get size of board
        boardX = board.transform.localScale.x;
        boardZ = board.transform.localScale.z;

        //Adjust scale to co-ordinates in world
        boardX *= 5;
        boardZ *= 5;

        //Need to fill the board with waypoints
        //Unity large squares are made up of 10 smaller squares
        //e.g. one x = 10 small inside it. Let's put 10 waypoints per 1 on x/y/z axis.

        //Fill the board with waypoints - we want to increment in tenths of X
        for(int i = 0; i <= boardX; i++)
        {
            for(int j = 0; j <= boardZ; j++)
            {
                //Place waypoints at a corrected height and place into an array for later use?
                print(i);
                Instantiate(waypoint, new Vector3(i, 0.5f, j), Quaternion.identity, pathHolder);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
