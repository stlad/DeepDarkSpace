using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    public int Speed = 1;
    private Vector2 previousMouse = new Vector2();
    public GameObject ActiveStar;
    private void OnMouseDrag()
    {
        Debug.Log("aa");
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 delta = (Vector2)mousePos - previousMouse;

        transform.Translate(delta.normalized*Speed, Space.Self);
        previousMouse = mousePos;
    }

}
