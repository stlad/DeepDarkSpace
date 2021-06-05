using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationStarController : MonoBehaviour
{
    public bool IsActive = false;
    public int Id;
    public GameObject Compass;
    public static HashSet<GameObject> Stars = new HashSet<GameObject>();
    void Start()
    {
        Stars.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Compass.GetComponent<ShipController>().ActiveStar == gameObject)
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
