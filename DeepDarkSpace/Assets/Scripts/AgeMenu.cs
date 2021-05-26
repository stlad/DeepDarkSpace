using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeMenu : MonoBehaviour
{
    public List<GameObject> Buttons;
    void Start()
    {
        //Buttons.AddRange(transform.Get())
        foreach(Transform child in transform)
        {
            Buttons.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
