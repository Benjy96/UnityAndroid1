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

    //Waypoint Holder
    public Transform pathHolder;
    //Waypoint prefab
    public Transform waypoint;

	void Start () {
        PlaceWaypoints();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlaceWaypoints()
    {
        //Get size of board
        boardX = board.transform.localScale.x;
        boardZ = board.transform.localScale.z;

        //Adjust scale to co-ordinates in world
        boardX *= 5;
        boardZ *= 5;
        boardX--;
        boardZ--;

        //Fill top left quadrant
        for (int i = 0; i <= boardX; i += 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                //Place waypoints at a corrected height and place into an array for later use?
                Instantiate(waypoint, new Vector3(i, 0.5f, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill bottom left quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                Instantiate(waypoint, new Vector3(i, 0.5f, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill top right quadrant
        for (int i = 0; i < boardX; i += 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                Instantiate(waypoint, new Vector3(i, 0.5f, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill bottom right quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                Instantiate(waypoint, new Vector3(i, 0.5f, j), Quaternion.identity, pathHolder);
            }
        }
    }
}
