using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheoryImageGetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sprite image = Resources.Load<Sprite>($"{CurrentCondition.AgeType}_{CurrentCondition.LevelType}_{CurrentCondition.LevelId}");
        gameObject.GetComponent<Image>().sprite = image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
