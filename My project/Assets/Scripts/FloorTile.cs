using Unity.VisualScripting;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject collectiblePrefab;

    public int collectibleAmount = 10;
    TileSpawn tileSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //Locate and return the object for tile spawn
        tileSpawn = GameObject.FindObjectOfType<TileSpawn>();
    }

    void OnTriggerExit(Collider other)
    {
        tileSpawn.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public void SpawnObstacle()
    {
        //Randomly spawn obstacle on the three given points
        int obstacleIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleIndex).transform;

        //Spawn obstacle at the given position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

    public void SpawnCollectibles()
    {
        for (int i = 0; i < collectibleAmount; i++)
        {
            GameObject temp = Instantiate(collectiblePrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
