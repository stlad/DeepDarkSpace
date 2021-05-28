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
        //var levels = gameObject.transform.Find("Levels").transform.Find();
        //Buttons.AddRange(transform.Get())
        foreach(Transform child in LevelDirectory.transform)
        {
            if (child.gameObject.GetComponent<LevelPanel>() != null)
                Buttons.Add(child.gameObject);
            //else
            //    NameOfAge = child.gameObject.GetComponent<Text>();
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
