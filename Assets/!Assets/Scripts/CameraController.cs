using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private float xBound = 3;
    private float yBound = 5;
    private float cameraSmoothSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Mathf.Abs(player.position.x - transform.position.x) > xBound)
            {
            Vector3 cameraTarget = new Vector3(player.position.x - Mathf.Sign(player.position.x - transform.position.x) * xBound, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, cameraTarget, 5f);
            }


    }
}
