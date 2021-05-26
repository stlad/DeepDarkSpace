using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public GameObject ParentOfProgress;
    public float maxValue => GetCurrentMax();
    public float Speed;
    void Start()
    {
    }

    void Update()
    {
        var fillProgress = gameObject.GetComponent<Image>().fillAmount;
        //Debug.Log($"max  {GetCurrentMax()}");
        if (fillProgress < GetCurrentMax()) 
            gameObject.GetComponent<Image>().fillAmount += 0.001f * Speed;
    }

    private float GetCurrentMax()
    {
        var parentScript = ParentOfProgress.GetComponent<AgeMenu>();
        return (float)parentScript.CompletedLevelsAmount/ parentScript.Buttons.Count;
    }
}
