using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour
{
    public AudioSource crashAudio; 
    public AudioClip smallCrashSound;

    public GameObject hitEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            crashAudio.clip = smallCrashSound;
            crashAudio.Play();

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(other.gameObject);
        }
    }
}