using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScale : MonoBehaviour
{
    public void PointerEnter()
    {
        transform.localScale = new Vector2(0.8f, 0.8f);
    }

    public void PointerExit()
    {
        transform.localScale = new Vector2(0.7f, 0.7f);
    }
}
