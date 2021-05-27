using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    public CurrentCondition.LevelTypes LevelType;
    public bool IsComplete = false;
    public int LevelId;


    void Start()
    {
        var t = transform.Find("Text").GetComponent<Text>();
        t.text = LevelType.ToString();
        Debug.Log($"{(int)LevelType}");
    }
    public void SetCompleted() => IsComplete = true;

    public void ChangeCurrentCondition()
    {
        CurrentCondition.AgeType = gameObject.GetComponentInParent<AgeMenu>().AgeType;
        CurrentCondition.LevelId = LevelId;
        CurrentCondition.LevelType = LevelType;
    }
}
