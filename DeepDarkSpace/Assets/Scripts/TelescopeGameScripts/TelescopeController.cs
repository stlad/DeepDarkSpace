using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TelescopeController : MonoBehaviour
{
    public GameObject ActiveSkyObject;
    public GameObject DescriptionPanel;
    private void Update()
    {
        var crosshair = transform.Find("Crosshair");
        var ray = new Ray2D(crosshair.transform.position, transform.forward);
        var hits = Physics2D.RaycastAll(ray.origin, ray.direction * 3000f).ToList();
        Debug.DrawRay(ray.origin, ray.direction * 3000f, Color.red);
        if (hits.Where(n=> n.transform.gameObject==ActiveSkyObject).Count()==0) 
                ActiveSkyObject = null;
        foreach (var hit in hits)
        {
            Debug.Log(hit.transform);
            if (hit.transform.gameObject.GetComponent<SkyObject>())
            {
                ActiveSkyObject = hit.transform.gameObject;
            }
        }
        if (ActiveSkyObject != null)
            DescriptionPanel.GetComponent<Text>().text = ActiveSkyObject.GetComponent<SkyObject>().Description;
        else DescriptionPanel.GetComponent<Text>().text = "...";
    }
}
