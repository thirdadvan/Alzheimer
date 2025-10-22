using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float movementSpeed = 2f;
    private float deadzone = 0.01f;
    private float rotationTimer;
    [SerializeField]private GameObject avatar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position = new Vector3(transform.position.x + movementSpeed*Time.deltaTime, transform.position.y, transform.position.z);
            avatar.transform.rotation = Quaternion.Euler(0, 90, 0);
            avatar.GetComponent<Animator>().SetBool("isWalking",true);
            rotationTimer = 0;
        }

        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position = new Vector3(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            avatar.transform.rotation = Quaternion.Euler(0, -90, 0);
            avatar.GetComponent<Animator>().SetBool("isWalking", true);
            rotationTimer = 0;
        }

        else if(Input.GetAxis("Horizontal") == 0)
        {
            rotationTimer = rotationTimer + Time.deltaTime;
            if (rotationTimer > deadzone)
            {
                avatar.GetComponent<Animator>().SetBool("isWalking", false);

            }
            
        }

    }
}
