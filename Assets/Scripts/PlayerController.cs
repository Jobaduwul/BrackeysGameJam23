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
    // Start is called before the first frame update
    void Start()
    {
        shipRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = -Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hInput, 0, 0) * horizontalSpeed * Time.deltaTime);
    }
}
