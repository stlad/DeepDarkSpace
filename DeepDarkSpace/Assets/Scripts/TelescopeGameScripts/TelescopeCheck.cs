using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelescopeCheck : MonoBehaviour
{
    public GameObject CurrentCondition;
    public GameObject Telescope;
    public int CorrectId;

    public void CheckCompletion()
    {
        var answer = Telescope.GetComponent<TelescopeController>().ActiveSkyObject.GetComponent<SkyObject>().Id;
        if (CorrectId == answer)
        {
            gameObject.GetComponent<Image>().color = Color.green;
            CurrentCondition.GetComponent<CurrentCondition>().SetLevelCompleted();
        }
        else gameObject.GetComponent<Image>().color = Color.red;
    }
}
