using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

//Хранит информацию об временной эпохе (меню)
public class AgeMenu : MonoBehaviour
{
    [SerializeField] 
    public List<GameObject> Buttons;
    public GameObject LevelDirectory;
    public int CompletedLevelsAmount => GetCompletedAmount();


    public CurrentCondition.AgeTypes AgeType;

    void Start()
    {
        foreach(Transform child in LevelDirectory.transform)
        {
            var levelPanel = child.gameObject.GetComponent<LevelPanel>();
            if ( levelPanel != null)
            {
                Buttons.Add(child.gameObject);
                CurrentCondition.AllLevels.Add(Tuple.Create(levelPanel.LevelId, levelPanel.LevelType, AgeType));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int GetCompletedAmount()
    {
        return Buttons.Where(n =>
        {
            LevelButton script = n.GetComponent<LevelButton>();
            return script.IsComplete;
        }).Count();
    }
}
