using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static int health = 3;
    public int maxHealth = 3;
    public Image[] hearts;
    public Sprite redHeart;
    public Sprite greenHeart;
    public Sprite yellowHeart;
    public Sprite emptyHeart;

    private double healthPercentage;

    private void Awake()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //by default everything is empty heart
        foreach (Image heart in hearts) 
        {
            heart.sprite = emptyHeart;
        }

        healthPercentage = ((float)health / maxHealth) * 100.0f;

        //temporarily commenting this to show some other stats
        //Debug.Log("Health: " + healthPercentage);

        //according to health, the full hearts are being filled
        for(int i = 0; i < health; i++) 
        {
            if(healthPercentage < 40.0f)
            {
                hearts[i].sprite = redHeart;
            }
            else if (healthPercentage < 75.0f)
            {
                hearts[i].sprite = yellowHeart;
            }
            else
            {
                hearts[i].sprite = greenHeart;
            }

        }
    }
}
