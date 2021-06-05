using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    public int Speed = 1;
    public GameObject ActiveStar;
    Vector2 previousPos = new Vector2();
    private void OnMouseDrag()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        var dMouse = mousePos - previousPos;
        transform.Translate(dMouse, Space.World);
    }
    private void OnMouseUp()
    {
        previousPos = new Vector2();
    }
    private void OnMouseDown()
    {
        previousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; ;
    }

}
