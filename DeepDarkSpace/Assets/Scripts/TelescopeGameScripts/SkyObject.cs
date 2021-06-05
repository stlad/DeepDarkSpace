using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyObject : MonoBehaviour
{
    public bool IsActive;
    public int Id;
    public GameObject Telescope;
    void Update()
    {
        if (Telescope.GetComponent<TelescopeController>().ActiveSkyObject == gameObject)
        {
            IsActive = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else
        {
            IsActive = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
