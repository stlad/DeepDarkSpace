using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    //public LimitedSizeLIst<GameObject> ActiveStars = new LimitedSizeLIst<GameObject>(2);
    public  List<GameObject> ActiveStars = new List<GameObject>();
    public int Limit;

    public void Add(GameObject star)
    {
        if (ActiveStars.Count == Limit)
        {
            ActiveStars[0].GetComponent<StarController>().IsActive = false;
            ActiveStars.RemoveAt(0);
        }
        ActiveStars.Add(star);
        star.GetComponent<StarController>().IsActive = true ;
    }

    public void Remove(GameObject star)
    {
        ActiveStars.Remove(star);
        star.GetComponent<StarController>().IsActive = false;
    }
}
