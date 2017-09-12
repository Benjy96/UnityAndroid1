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

    //Store placed object locations
    private List<Vector3> spawnPositions;

    //Waypoint Holder
    public Transform pathHolder;
    //Waypoint prefab
    public Transform waypoint;

    void Start()
    {
        spawnPositions = new List<Vector3>();



        //Need code to place player and walls before the waypoints, and mark their position so that waypoint skips over them when looping
        PlaceObjects(waypoint, .5f);
    }

    private void PlaceObjects(Transform toPlace, float yAxisHeight)
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
                Instantiate(toPlace, new Vector3(i, yAxisHeight, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill bottom left quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                Instantiate(toPlace, new Vector3(i, yAxisHeight, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill top right quadrant
        for (int i = 0; i < boardX; i += 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                Instantiate(toPlace, new Vector3(i, yAxisHeight, j), Quaternion.identity, pathHolder);
            }
        }

        //Fill bottom right quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                Instantiate(toPlace, new Vector3(i, yAxisHeight, j), Quaternion.identity, pathHolder);
            }
        }
    }

    //what if we loop through a list and every entry is a possible spawn point? then we can REMOVE the spawn points from the list with a list's functionality
    private void MarkSpawnPoints()
    {
        //Fill top left quadrant
        for (int i = 0; i <= boardX; i += 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }

        //Fill bottom left quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }

        //Fill top right quadrant
        for (int i = 0; i < boardX; i += 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }

        //Fill bottom right quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }
    }


}
