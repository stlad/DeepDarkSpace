
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float Sensivity;
    public GameObject ActiveStar { get; private set; }
    void Update()
    {
        var ray = new Ray2D(transform.position, transform.up);
        var hits = Physics2D.RaycastAll(transform.position, transform.up*1000f);
        Debug.DrawRay(ray.origin, ray.direction*1000f, Color.red);
        foreach(var hit in hits)
        {
            if (hit.transform.gameObject.GetComponent<NavigationStarController>())
            {
                ActiveStar = hit.transform.gameObject;
                Debug.Log(hit.transform);
            }
        }
    }

    private void OnMouseDrag()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = mousePos - gameObject.transform.position;
        var zAngle = Mathf.Atan2(pos.x, pos.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, -zAngle * Sensivity);
    }
}
