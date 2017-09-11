using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class replaces waypoint manager.
/// Will instantiate player, guards, and obstacles within this script.
/// This will allow me to check whether or not a space is taken, and allow me to choose
/// whether or not a waypoint should be placed there. (Waypoints should only go in free space.)
/// </summary>
public class BoardManager : MonoBehaviour {

    //Board and its size along horizontal/vertical
    public GameObject board;
    private float boardX;
    private float boardZ;

    //Waypoint Holder
    public Transform pathHolder;
    //Waypoint prefab
    public Transform waypoint;

    void Start()
    {
        //Need code to place player and walls before the waypoints, and mark their position so that waypoint skips over them when looping
        PlaceObjects(waypoint);
    }

    private void PlaceObjects(Transform toPlace)
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
                Instantiate(toPlace, new Vector3(i, .5f, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill bottom left quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                Instantiate(toPlace, new Vector3(i, .5f, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill top right quadrant
        for (int i = 0; i < boardX; i += 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                Instantiate(toPlace, new Vector3(i, .5f, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill bottom right quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                Instantiate(toPlace, new Vector3(i, .5f, j), Quaternion.identity, pathHolder);
            }
        }
    }
}
