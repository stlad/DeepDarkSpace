using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public  bool IsCorrect;
    public bool IsClicked = false;
    public GameObject CurrentCond;
    
    void Start()
    {
        var button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => 
        {
            IsClicked = true;
            if (IsCorrect)
                CurrentCond.GetComponent<CurrentCondition>().SetLevelCompleted(); 
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (IsClicked)
        {
            if (IsCorrect)
                gameObject.GetComponent<Image>().color = Color.green;
            else
                gameObject.GetComponent<Image>().color = Color.red;
        }
    }
    
    
}
