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
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width ||
            screenPos.y < 0 || screenPos.y > Screen.height)
        {
            if(gameObject.CompareTag("Sensor") && gameManager.isDead==false)
            {
                gameManager.IncrementScore(1);
            }
            Destroy(gameObject);
        }
    }
}
