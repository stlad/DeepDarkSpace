using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelescopeCheck : MonoBehaviour
{
    public GameObject CurrentCondition;
    public GameObject Telescope;
    public GameObject CorrectObject;

    public void CheckCompletion()
    {
        var answer = Telescope.GetComponent<TelescopeController>().ActiveSkyObject.GetComponent<SkyObject>();
        if (CorrectObject.GetComponent<SkyObject>() == answer || answer !=null)
        {
            gameObject.GetComponent<Image>().color = Color.green;
            CurrentCondition.GetComponent<CurrentCondition>().SetLevelCompleted();
        }
        else gameObject.GetComponent<Image>().color = Color.red;
    }
}
