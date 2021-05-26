using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeProgress : MonoBehaviour
{
    public GameObject ParentOfProgress;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var parentScript = ParentOfProgress.GetComponent<AgeMenu>();
        var text = gameObject.GetComponent<Text>();
        text.text = $"{parentScript.CompletedLevelsAmount}/{parentScript.Buttons.Count}";
    }
}
