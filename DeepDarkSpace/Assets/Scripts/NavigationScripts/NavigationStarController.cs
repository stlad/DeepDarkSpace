using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationStarController : MonoBehaviour
{
    public bool IsActive = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive) gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        else gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
