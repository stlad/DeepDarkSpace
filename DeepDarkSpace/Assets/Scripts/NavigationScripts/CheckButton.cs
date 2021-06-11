using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckButton : MonoBehaviour
{
    public GameObject Ship;
    public GameObject CurrentCondition;
    public GameObject NextLevelButton;
    public GameObject CorrectStar;
    public void CheckCorrection()
    {
        var activeStar = Ship.GetComponent<ShipController>().ActiveStar.GetComponent<NavigationStarController>();
        var correct = CorrectStar.GetComponent<NavigationStarController>();
        if (activeStar == correct)
        {
            gameObject.GetComponent<Image>().color = Color.green;
            CurrentCondition.GetComponent<CurrentCondition>().SetLevelCompleted();
            NextLevelButton.SetActive(true);

        }
        else gameObject.GetComponent<Image>().color = Color.red;
    }
}
