using Unity.VisualScripting;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    TileSpawn tileSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //Locate and return the object for tile spawn
        tileSpawn = GameObject.FindObjectOfType<TileSpawn>();
    }

    void OnTriggerExit(Collider other)
    {
        tileSpawn.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
