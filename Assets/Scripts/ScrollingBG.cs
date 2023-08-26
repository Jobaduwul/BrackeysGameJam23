using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingBG : MonoBehaviour
{
    [SerializeField] private RawImage Img;
    [SerializeField] private float x, y;

    void Update()
    {
        Img.uvRect = new Rect(Img.uvRect.position + new Vector2(x, y) * Time.deltaTime, Img.uvRect.size);
    }

}
