using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform leftFirePoint;
    public Transform rightFirePoint;
    public GameObject firePrefab;
    public GameObject fire2Prefab;

    public float fireForce = 2f;
    public float fireRate = 0.2f;
    public float fire2Rate = 3f;
    private float nextFireTime = 0f;
    private float nextFire2Time = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }

        if (Input.GetButton("Fire2") && Time.time >= nextFire2Time)
        {
            nextFire2Time = Time.time + fire2Rate;
            ShootTwice();
        }
    }

    void Shoot()
    {
        GameObject fire = Instantiate(firePrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = fire.GetComponent<Rigidbody>();

        rb.velocity = -firePoint.up * fireForce;


    }

    void ShootTwice()
    {
        GameObject fireLeft = Instantiate(fire2Prefab, leftFirePoint.position, leftFirePoint.rotation);
        GameObject fireRight = Instantiate(fire2Prefab, rightFirePoint.position, rightFirePoint.rotation);

        Rigidbody rbLeft = fireLeft.GetComponent<Rigidbody>();
        Rigidbody rbRight = fireRight.GetComponent<Rigidbody>();

        rbLeft.velocity = -leftFirePoint.up * fireForce;
        rbRight.velocity = -rightFirePoint.up * fireForce;

    }
}
