using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButton : MonoBehaviour
{
    public GameObject Ship;
    public GameObject CurrentCondition;
    public int CorrectStarId;
    public void CheckCorrection()
    {
        var activeStar = Ship.GetComponent<ShipController>().ActiveStar;
        var id = activeStar.GetComponent<NavigationStarController>().Id;
        if (id == CorrectStarId)
        {
            gameObject.GetComponent<Image>().color = Color.green;
            CurrentCondition.GetComponent<CurrentCondition>().SetLevelCompleted();
        }
        else gameObject.GetComponent<Image>().color = Color.red;
    }
}
