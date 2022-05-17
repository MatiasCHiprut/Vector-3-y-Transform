using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementspeed; 

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(movementspeed, 0, 0);
            //0.1f = float 0.1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(movementspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, movementspeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, movementspeed, 0);
        }
    }
}
