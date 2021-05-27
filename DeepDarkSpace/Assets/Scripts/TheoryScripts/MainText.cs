using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextAsset text = (TextAsset)Resources.Load($"{CurrentCondition.AgeType}_{CurrentCondition.LevelType}_{CurrentCondition.LevelId}");
        //var viewport = gameObject.transform.Find("Viewport");
        gameObject.GetComponent<Text>().text = text.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
