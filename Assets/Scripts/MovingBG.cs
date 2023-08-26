using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBG : MonoBehaviour
{
    [SerializeField] private RawImage Img;
    [SerializeField] private float moveSpeed = 1.0f;

    void Update()
    {
        Vector3 currentPosition = Img.transform.position;
        currentPosition += new Vector3(moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime);

        Img.transform.position = currentPosition;
    }
}
