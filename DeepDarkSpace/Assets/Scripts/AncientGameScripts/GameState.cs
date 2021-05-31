using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    //public LimitedSizeLIst<GameObject> ActiveStars = new LimitedSizeLIst<GameObject>(2);
    public  List<GameObject> ActiveStars = new List<GameObject>();
    public List<GameObject> Edges = new List<GameObject>(); 
    public int Limit = 2;
    public GameObject AddEdgeButton;
    public GameObject EdgePrefab;

    public void Add(GameObject star)
    {
        if (ActiveStars.Count == Limit)
        {
            ActiveStars[0].GetComponent<StarController>().IsActive = false;
            ActiveStars.RemoveAt(0);
        }
        ActiveStars.Add(star);
        star.GetComponent<StarController>().IsActive = true ;

        if (ActiveStars.Count == Limit) AddEdgeButton.SetActive(true);
        else AddEdgeButton.SetActive(false);
    }

    public void Remove(GameObject star)
    {
        ActiveStars.Remove(star);
        star.GetComponent<StarController>().IsActive = false;
        AddEdgeButton.SetActive(false);
    }

    public void InstantiateEdgeWithActiveStars()
    {
        var edge = Instantiate(EdgePrefab);
        var pos = new List<Vector3>();
        pos.Add(ActiveStars[0].transform.position);
        pos.Add(ActiveStars[1].transform.position);
        edge.GetComponent<LineRenderer>().SetPositions(pos.ToArray());

        Edges.Add(edge);
    }
}
