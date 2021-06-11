using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanel : MonoBehaviour
{
    public CurrentCondition CurrentCondition;
    public CurrentCondition.AgeTypes AgeType;
    public CurrentCondition.LevelTypes LevelType;
    public int LevelId;
    public bool IsCompleted => CheckLevelCompletion();

    private void Start()
    {
        var idField = gameObject.transform.Find("Id").GetComponent<Text>();
        idField.text = (LevelId+1).ToString();

        var typeField = gameObject.transform.Find("TypeOfLevel").GetComponent<Text>();
        typeField.text = CurrentCondition.ConvertLevelTypeToString(LevelType); //LevelType.ToString();
    }

    private void Update()
    {
        // монипуляции со спрайтом: можно менять
        var complete = gameObject.transform.Find("IsCompleteImage").GetComponent<Image>();

        if (IsCompleted) complete.color = Color.green;
        else complete.color = Color.red;
    }
    private bool CheckLevelCompletion()
    {
        return CurrentCondition.CompletedLevels
            .Where(n => n.Item1 == AgeType && n.Item2 == LevelId)
            .Count() !=0;
    }
}
