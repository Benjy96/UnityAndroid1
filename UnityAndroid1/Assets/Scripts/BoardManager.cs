using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Will instantiate player, guards, and obstacles within this script.
/// This will allow me to check whether or not a space is taken, and allow me to choose
/// whether or not a waypoint should be placed there. (Waypoints should only go in free space.)
/// </summary>
public class BoardManager : MonoBehaviour {

    private readonly int NumPositions;  //Constant calculated at runtime - equivalent to FINAL in java - const in C++
    
    //Board and its size along horizontal/vertical
    public GameObject board;
    private float boardX;
    private float boardZ;

    //Store potential object locations
    private List<Vector3> spawnPositions;

    public Transform pathHolder;
    public Transform waypoint;
    public Transform player;
    public Transform wallObject;

    void Start()
    {
        //Get size of board
        boardX = board.transform.localScale.x;
        boardZ = board.transform.localScale.z;

        //Adjust scale to co-ordinates in world (5 small squares per half of plane) - each increment of 1 on scale increases by 5 small squares on each side
        boardX *= 5;
        boardZ *= 5;
        boardX--;
        boardZ--;

        spawnPositions = new List<Vector3>();
        MarkSpawnPoints();

        // TODO: Need code to place player and walls before the waypoints, and mark their position so that waypoint skips over them when looping
        PlaceObjects(waypoint, .5f, pathHolder);
    }

    private void PlaceObjects(Transform toPlace, float yAxisHeight, Transform parent, int howMany)
    {
        while (spawnPositions.Count >= 0 && howMany > 0)   
        {
            //Get a random spawn position
            int randomIndex = Random.Range(0, spawnPositions.Count);
            Vector3 position = spawnPositions[randomIndex];
            //Create an object and remove potential spawn location from the pool
            Instantiate(toPlace, new Vector3(position.x, yAxisHeight, position.z), Quaternion.identity, parent);
            spawnPositions.RemoveAt(randomIndex);
            howMany--;
        }
    }

    //what if we loop through a list and every entry is a possible spawn point? then we can REMOVE the spawn points from the list with a list's functionality
    private void MarkSpawnPoints()
    {
        int calculateNumBoardPositions = 0;

        //Fill top left quadrant
        for (int i = 0; i <= boardX; i += 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                calculateNumBoardPositions++;
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

        // TODO: Add method for calculating number of positions at runtime
        calculateNumBoardPositions *= 4;

    }
}
