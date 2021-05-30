using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TestTextParser : MonoBehaviour
{
    public GameObject Question;
    public List<GameObject> Answers;
    public readonly int TestLevelCount;
    void Start()
    {
        var text = (TextAsset)Resources.Load($"{CurrentCondition.AgeType}_{CurrentCondition.LevelType}");
        var allStrings = text.text.Split('_');
        var str = allStrings.Where(n => n.Contains($"[{CurrentCondition.LevelId}]")).FirstOrDefault();
        var levelPrefixCount = 2 + CurrentCondition.LevelId.ToString().Count();

        var ansStr = str.Split('\n');
        Question.GetComponent<Text>().text = ansStr.First().Remove(0, levelPrefixCount);

        //Answers.ForEach((n,i)=>i+1)

        for(int i = 0; i<Answers.Count;i++)
        {
            if(ansStr[i + 1][0]=='*')
            {
                Answers[i].GetComponent<AnswerButton>().IsCorrect = true;
            }
            Answers[i].transform.Find("Text").GetComponent<Text>().text = ansStr[i+1].Trim('*');
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
