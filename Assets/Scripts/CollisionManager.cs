using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject player;
    public GameManager gameManager;
    public AudioClip crashSound;
    public AudioSource crashAudio;

    public GameObject hitEffect;
    public GameObject megaHitEffect;

    public GameObject GameOverCanvas;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        ToggleGameOver();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //crashAudio.PlayOneShot(crashSound);

            Debug.Log("Asteroid hit");
            GameObject asteroidHit = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(asteroidHit, 0.5f);
            HealthManager.health--;
            Debug.Log("Health: " + HealthManager.health);


            if (HealthManager.health <= 0)          // Game Over Explosion
            {
                gameManager.isDead = true;
                Debug.Log("Game Over. Final Score: " + gameManager.score);
                Destroy(player, 0.1f);
                GameObject effect = Instantiate(megaHitEffect, transform.position, Quaternion.identity);
                Destroy(effect, 0.8f);
                Debug.Log("Calling");
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

    private void ToggleGameOver() 
    {
        if(gameManager.isDead)
        {
            Debug.Log("GAME OVER");
            GameOverCanvas.SetActive(true);
            //Time.timeScale = 0f;
        }
    }
}
