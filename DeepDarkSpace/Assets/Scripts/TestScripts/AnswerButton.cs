using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public  bool IsCorrect;
    public bool IsClicked = false;
    public GameObject CurrentCond;
    public GameObject NextLevelButton;

    public Sprite TrueSprite;
    public Sprite FalseSprite;
    
    void Start()
    {
        var button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => 
        {
            IsClicked = true;
            if (IsCorrect)
            {
                CurrentCond.GetComponent<CurrentCondition>().SetLevelCompleted();
                NextLevelButton.SetActive(true);
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (IsClicked)
        {
            if (IsCorrect)
                gameObject.GetComponent<Image>().sprite = TrueSprite;
            else
                gameObject.GetComponent<Image>().sprite = FalseSprite;
        }
    }
    
    
}
