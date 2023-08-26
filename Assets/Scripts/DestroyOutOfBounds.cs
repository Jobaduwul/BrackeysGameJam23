using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameObject gameObject;
    public float topBound;
    //int score = 0;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            if(gameObject.CompareTag("Sensor"))
            {
                gameManager.IncrementScore(1);
            }
            Destroy(gameObject);
        }
    }
}
