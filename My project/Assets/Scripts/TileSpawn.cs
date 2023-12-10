using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public GameObject floorTile;
    Vector3 nextTileSpawn;

    public void SpawnTile()
    {
        //Spawn initial Floor Tile below player
        GameObject temp = Instantiate(floorTile, nextTileSpawn, Quaternion.identity);
        nextTileSpawn = temp.transform.GetChild(1).transform.position;
    }

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < 10; i++) {
            SpawnTile();
        }
    }
}
