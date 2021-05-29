using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TextParserForTheory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var text = (TextAsset)Resources.Load($"{CurrentCondition.AgeType}_{CurrentCondition.LevelType}");
        var allStrings = text.text.Split('_');
        var str = allStrings.Where(n => n.Contains($"[{CurrentCondition.LevelId}]")).FirstOrDefault();
        var levelPrefixCount = 2 + CurrentCondition.LevelId.ToString().Count();
        gameObject.GetComponent<Text>().text = str.Remove(0, levelPrefixCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
