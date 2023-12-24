using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float hInput;
    public float horizontalSpeed;
    public float verticalSpeed;
    public GameObject shipGo;
    public Rigidbody shipRb;
    int xRange = 18;
    // Start is called before the first frame update
    void Start()
    {
        shipRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(hInput, 0, 0) * horizontalSpeed * Time.deltaTime);
        hInput = 0;

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    public void MoveLeft()
    {
        hInput = 1; 
    }
    public void MoveRight()
    {
        hInput = -1;
    }
}
