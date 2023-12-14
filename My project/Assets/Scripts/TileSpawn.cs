using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    [SerializeField] GameObject floorTile;
    Vector3 nextTileSpawn;

    public void SpawnTile(bool spawnObjects)
    {
        //Spawn initial Floor Tile below player
        GameObject temp = Instantiate(floorTile, nextTileSpawn, Quaternion.identity);
        nextTileSpawn = temp.transform.GetChild(1).transform.position;

        if (spawnObjects)
        {
            temp.GetComponent<FloorTile>().SpawnObstacle();
            temp.GetComponent<FloorTile>().SpawnCollectibles();
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);

            }
        }
    }
}
