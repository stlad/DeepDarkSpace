using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationStarController : MonoBehaviour
{
    public bool IsActive = false;
    public int Id;
    public GameObject Ship;
    public static HashSet<GameObject> Stars = new HashSet<GameObject>();
    public Sprite ActiveSprite;
    public Sprite NotActiveSprtie;
    void Start()
    {
        Stars.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ship.GetComponent<ShipController>().ActiveStar == gameObject)
        {
            IsActive = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = ActiveSprite;
        }
        else
        {
            IsActive = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = NotActiveSprtie;
        }
    }
}
