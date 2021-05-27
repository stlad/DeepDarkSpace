using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AgeProgress : MonoBehaviour
{
    public GameObject ParentOfProgress;
    public int CompletedLevelsCount { get { return GetCompleteCount(); } }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //var count = parentScript.Buttons.Where((x,n)=> n
        //var count = CurrentCondition.CompletedLevels.Where(n => n.Item1 == type).Count(); 
        var parentScript = ParentOfProgress.GetComponent<AgeMenu>();
        var text = gameObject.GetComponent<Text>();
        text.text = $"{CompletedLevelsCount}/{parentScript.Buttons.Count}";
    }
    private int GetCompleteCount()
    {
        var parentScript = ParentOfProgress.GetComponent<AgeMenu>();
        var type = parentScript.AgeType;
        return CurrentCondition.CompletedLevels.Where(n => n.Item1 == type).Select(n => n.Item2).Count();
        
    }
}
