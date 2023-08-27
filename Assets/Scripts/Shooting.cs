using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform leftFirePoint;
    public Transform rightFirePoint;

    public Transform megaFirePoint1;
    public Transform megaFirePoint2;
    public Transform megaFirePoint3;
    public Transform megaFirePoint4;
    public Transform megaFirePoint5;

    public GameObject firePrefab;
    public GameObject fire2Prefab;
    public GameObject fire3Prefab;


    public float fireForce = 50f;
    public float fireRate = 0.1f;
    public float fire2Rate = 1f;
    public float fire3Rate = 2f;
    private float nextFireTime = 0f;
    private float nextFire2Time = 0f;
    private float nextFire3Time = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }

        if (Input.GetButton("Fire2") && Time.time >= nextFire2Time)
        {
            nextFire2Time = Time.time + fire2Rate;
            ShootTwice();
        }

        if (Input.GetButton("Fire3") && Time.time >= nextFire3Time)
        {
            nextFire3Time = Time.time + fire3Rate;
            MegaShoot();
        }
    }

    void Shoot()
    {
        GameObject fire = Instantiate(firePrefab, firePoint.position, Quaternion.identity);

        Rigidbody rb = fire.GetComponent<Rigidbody>();

        rb.velocity = -firePoint.up * fireForce;


    }

    void ShootTwice()
    {
        GameObject fireLeft = Instantiate(fire2Prefab, leftFirePoint.position, Quaternion.identity);
        GameObject fireRight = Instantiate(fire2Prefab, rightFirePoint.position, Quaternion.identity);

        Rigidbody rbLeft = fireLeft.GetComponent<Rigidbody>();
        Rigidbody rbRight = fireRight.GetComponent<Rigidbody>();

        rbLeft.velocity = -leftFirePoint.up * fireForce;
        rbRight.velocity = -rightFirePoint.up * fireForce;

    }

    void MegaShoot()
    {
        GameObject megaFire1 = Instantiate(fire3Prefab, megaFirePoint1.position, Quaternion.identity);
        GameObject megaFire2 = Instantiate(fire3Prefab, megaFirePoint2.position, Quaternion.identity);
        GameObject megaFire3 = Instantiate(fire3Prefab, megaFirePoint3.position, Quaternion.identity);
        GameObject megaFire4 = Instantiate(fire3Prefab, megaFirePoint4.position, Quaternion.identity);
        GameObject megaFire5 = Instantiate(fire3Prefab, megaFirePoint5.position, Quaternion.identity);

        Rigidbody rbMega1 = megaFire1.GetComponent<Rigidbody>();
        Rigidbody rbMega2 = megaFire2.GetComponent<Rigidbody>();
        Rigidbody rbMega3 = megaFire3.GetComponent<Rigidbody>();
        Rigidbody rbMega4 = megaFire4.GetComponent<Rigidbody>();
        Rigidbody rbMega5 = megaFire5.GetComponent<Rigidbody>();

        rbMega1.velocity = -megaFirePoint1.up * fireForce;
        rbMega2.velocity = -megaFirePoint2.up * fireForce;
        rbMega3.velocity = -megaFirePoint3.up * fireForce;
        rbMega4.velocity = -megaFirePoint4.up * fireForce;
        rbMega5.velocity = -megaFirePoint5.up * fireForce;


    }

}