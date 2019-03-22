using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnitDirectionVectorTest : MonoBehaviour
{

    public Dictionary<string, Vector3> directions = new Dictionary<string, Vector3>();
    public MoveForward spawnItem;

    void Start()
    {
        directions.Add("Up", new Vector3(0, 1, 0));
        directions.Add("UpRight", new Vector3(1, 1, 0));
        directions.Add("Right", new Vector3(1, 0, 0));
        directions.Add("DownRight", new Vector3(1, -1, 0));
        directions.Add("Down", new Vector3(0, -1, 0));
        directions.Add("DownLeft", new Vector3(-1, -1, 0));
        directions.Add("Left", new Vector3(-1, 0, 0));
        directions.Add("UpLeft", new Vector3(-1, 1, 0));

        StartCoroutine(SpawnInDirections());
    }

    IEnumerator SpawnInDirections()
    {
        while (true) { 
            yield return new WaitForSeconds(5);
            foreach (Vector3 nextDirection in directions.Values)
            {
                MoveForward moveForward = Instantiate(spawnItem,
                    nextDirection.normalized,
                    new Quaternion(0, 0, 0, 0));
                moveForward.direction = nextDirection;
            }
        }
    }
}
