using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Add a method to stop walls blocking a path to the finish line when player spawns in - maybe one straight path to player reserved?
// Reserve 0 x axis (middle)
//35 on z is player start
//-35 is finish
/// <summary>
/// Will instantiate player, guards, and obstacles within this script.
/// This will allow me to check whether or not a space is taken, and allow me to choose
/// whether or not a waypoint should be placed there. (Waypoints should only go in free space.)
/// </summary>
public class BoardManager : MonoBehaviour {

    private List<Vector3> reservedPath; 
    
    //Board and its size along horizontal/vertical
    public GameObject board;
    private float boardX;
    private float boardZ;

    //Store potential object locations
    private List<Vector3> spawnPositions;

    //GameObjects to be placed on the board
    public Transform pathHolder;
    public Transform waypoint;

    public Transform player;

    public Transform wallParent;
    public Transform wallObject;

    public Transform finishPoint;
    public Transform guardHolder;
    public Transform guard;

    void Start()
    {
        reservedPath = new List<Vector3>();
        spawnPositions = new List<Vector3>();
        CalculateBoardSize();
        MarkSpawnPoints();
        // TODO: Implement way of dynamically calculating the maximum number of objects that can be placed on the board
        // TODO: Implement difficulty system that then affects the above max number (for guards)
        PlaceObjects(null, 1f, null, 1, true);  //Spawns player (start) and finish (end) points.
        PlaceObjects(wallObject, 2.5f, wallParent, 5, false);
        PlaceObjects(guard, 1f, guardHolder, 10, false);   // TODO: Need the howMany to be done with a difficulty variable
        PlaceObjects(waypoint, .5f, pathHolder, spawnPositions.Count, false);      //DO LAST: Fill the rest of the board with waypoints
    }

    private bool ReservedPointCheck(float x, float z)
    {
        if(x == 0 && z == 35 || x == 0 && z == -35)
        {
            reservedPath.Add(new Vector3(x, 0f, z));
            return true;
        }
        return false;
    }

    private void CalculateBoardSize()
    {
        //Get size of board
        boardX = board.transform.localScale.x;
        boardZ = board.transform.localScale.z;

        //Adjust scale to co-ordinates in world (5 small squares per half of plane) - each increment of 1 on scale increases by 5 small squares on each side
        boardX *= 5;
        boardZ *= 5;
        boardX--;
        boardZ--;
    }

    /// <summary>
    /// Create a List of Vector3s containing potential spawn points.
    /// Increment the spawn points in +=5 allows boxes to sit beside each other perfectly. (Box has scale 5/5/5/)
    /// e.g. x co-ordinate (Transform.position.x) increments by 5
    /// </summary>
    private void MarkSpawnPoints()
    {
        //Fill top left quadrant
        for (int i = 0; i <= boardX; i += 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                if(ReservedPointCheck(i, j))
                {
                    continue;
                }
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }

        //Fill bottom left quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j <= boardZ; j += 5)
            {
                if (ReservedPointCheck(i, j))
                {
                    continue;
                }
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }

        //Fill top right quadrant
        for (int i = 0; i < boardX; i += 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                if (ReservedPointCheck(i, j))
                {
                    continue;
                }
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }

        //Fill bottom right quadrant
        for (int i = 0; i >= -boardX; i -= 5)
        {
            for (int j = 0; j >= -boardZ; j -= 5)
            {
                if (ReservedPointCheck(i, j))
                {
                    continue;
                }
                spawnPositions.Add(new Vector3(i, 0f, j));
            }
        }
    }

    /// <summary>
    /// Randomly spawn objects on the board using the potential spawnPositions list. Remove points from list once assigned to.
    /// </summary>
    /// <param name="toPlace"></param>
    /// <param name="yAxisHeight"></param>
    /// <param name="parent"></param>
    /// <param name="howMany"></param>
    private void PlaceObjects(Transform toPlace, float yAxisHeight, Transform parent, int howMany, bool firstPoints)
    {
        while (spawnPositions.Count >= 0 && howMany > 0)   
        {
            if (firstPoints)  //Set start and end points
            {
                //Spawn player at start of board
                int startPointIndex = (spawnPositions.Count / 4) - 1;   //Board is made of four quadrants
                Vector3 startPoint = spawnPositions[startPointIndex];
                Instantiate(player, new Vector3(startPoint.x, yAxisHeight, startPoint.z), Quaternion.identity, parent);
                spawnPositions.RemoveAt(startPointIndex);
                //Spawn finish point at end of the board
                int endPointIndex = spawnPositions.Count - 1;
                Vector3 endPoint = spawnPositions[endPointIndex];
                Instantiate(finishPoint, new Vector3(endPoint.x, endPoint.y, endPoint.z), Quaternion.identity, null);
                spawnPositions.RemoveAt(endPointIndex);
            }
            else
            {
                int randomIndex = Random.Range(0, spawnPositions.Count);
                Vector3 position = spawnPositions[randomIndex];
                Instantiate(toPlace, new Vector3(position.x, yAxisHeight, position.z), Quaternion.identity, parent);
                spawnPositions.RemoveAt(randomIndex);
            }
            howMany--;
        }
    }   
}