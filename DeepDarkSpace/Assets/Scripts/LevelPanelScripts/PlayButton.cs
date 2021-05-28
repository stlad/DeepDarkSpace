using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void SetNewLevel()
    {
        var levelPanel = gameObject.GetComponentInParent<LevelPanel>();
        CurrentCondition.AgeType = levelPanel.AgeType;
        CurrentCondition.LevelType = levelPanel.LevelType;
        CurrentCondition.LevelId = levelPanel.LevelId;
    }
}
