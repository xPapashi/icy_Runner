using Unity.VisualScripting;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    public GameObject obstaclePrefab;
    TileSpawn tileSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //Locate and return the object for tile spawn
        tileSpawn = GameObject.FindObjectOfType<TileSpawn>();
        SpawnObstacle();
    }

    void OnTriggerExit(Collider other)
    {
        tileSpawn.SpawnTile();
        Destroy(gameObject, 2);
    }

    void SpawnObstacle()
    {
        //Randomly spawn obstacle on the three given points
        int obstacleIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleIndex).transform;

        //Spawn obstacle at the given position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
