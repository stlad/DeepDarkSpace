
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float Sensivity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray2D(transform.position, transform.up);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up*1000f);
        Debug.DrawRay(ray.origin, ray.direction*1000f, Color.red);
        if(hit)
        {
            if (hit.transform.gameObject.GetComponent<NavigationStarController>())
            Debug.Log(hit.transform);
                //hit.transform.gameObject.GetComponent<NavigationStarController>().IsActive = true;
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
