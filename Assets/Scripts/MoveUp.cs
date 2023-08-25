using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(gameObject.CompareTag("Background"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        */
        //if (gameObject.CompareTag("Enemy"))
        //{
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        //}
    }
}
