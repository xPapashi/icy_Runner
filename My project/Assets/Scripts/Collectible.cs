using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] public float collectibleSpeed = 90f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }

        // Debug.Log("Interacted with " + other.gameObject.name);

        if (other.gameObject.name != "PlayerObj")
        {
            return;
        }

        GameManager.inst.IncrementScore();
        Destroy(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, collectibleSpeed * Time.deltaTime);
    }
}
