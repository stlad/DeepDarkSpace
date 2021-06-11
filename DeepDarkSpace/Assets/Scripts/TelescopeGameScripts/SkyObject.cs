using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyObject : MonoBehaviour
{
    public bool IsActive;
    public int Id;
    public GameObject Telescope;
    public string Description;
    public Sprite NotActiveSprite;
    public Sprite ActiveSprite;
    void Update()
    {
        if (Telescope.GetComponent<TelescopeController>().ActiveSkyObject == gameObject)
        {
            IsActive = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = ActiveSprite;
            //Telescope.GetComponent<TelescopeController>().DescriptionPanel.GetComponent<Text>().text = Description;
        }
        else
        {
            IsActive = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = NotActiveSprite;
        }
    }
}
