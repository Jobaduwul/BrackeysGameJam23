using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject player;
    public GameManager gameManager;
    public AudioClip crashSound;
    public AudioSource crashAudio;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Enemy"))
        {
            //crashAudio.PlayOneShot(crashSound);

            Debug.Log("Asteroid hit");
            HealthManager.health--;
            Debug.Log("Health: " + HealthManager.health);


            if(HealthManager.health <= 0 )
            {
                Debug.Log("Game Over. Final Score: " + gameManager.score);
                Destroy(player);
            }
            else
            {
                // Display current health and score
                Debug.Log("Player Health: " + HealthManager.health);
                Debug.Log("Score: " + gameManager.score);
            }
            Destroy(other.gameObject);
        }
    }
}
