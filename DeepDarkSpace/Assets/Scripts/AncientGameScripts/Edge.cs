using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
    public GameObject From = new GameObject();
    public GameObject To = new GameObject();

    void Start()
    {
        var line = gameObject.GetComponent<LineRenderer>();
        var pos = new List<Vector3>();
        pos.Add(From.transform.position);
        pos.Add(To.transform.position);
        line.SetPositions(pos.ToArray());
        Instantiate(line);
        var state = gameObject.GetComponentInParent<GameState>();
        state.GetComponent<GameState>().Edges.Add(gameObject);
    }
}
