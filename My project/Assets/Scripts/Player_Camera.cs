using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform Camera;

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.position;
    }
}
