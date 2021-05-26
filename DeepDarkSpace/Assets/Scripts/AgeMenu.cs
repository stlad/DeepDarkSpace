using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AgeMenu : MonoBehaviour
{
    [SerializeField] 
    public List<GameObject> Buttons;
    public Text NameOfAge;
    public int CompletedLevelsAmount => GetCompletedAmount();
    void Start()
    {
        //Buttons.AddRange(transform.Get())
        foreach(Transform child in transform)
        {
            if (child.gameObject.GetComponent<LevelButton>() != null)
                Buttons.Add(child.gameObject);
            else
                NameOfAge = child.gameObject.GetComponent<Text>();
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
