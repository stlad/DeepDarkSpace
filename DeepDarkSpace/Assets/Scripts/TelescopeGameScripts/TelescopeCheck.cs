using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelescopeCheck : MonoBehaviour
{
    public GameObject CurrentCondition;
    public GameObject Telescope;
    public GameObject CorrectObject;
    public Sprite CorrectSprite;
    public Sprite InCorrectSprite;
    public void CheckCompletion()
    {
        var answer = Telescope.GetComponent<TelescopeController>().ActiveSkyObject.GetComponent<SkyObject>();
        if (CorrectObject.GetComponent<SkyObject>() == answer && answer !=null)
        {
            gameObject.GetComponent<Image>().sprite = CorrectSprite;
            CurrentCondition.GetComponent<CurrentCondition>().SetLevelCompleted();
        }
        else gameObject.GetComponent<Image>().sprite = InCorrectSprite;
    }
}
