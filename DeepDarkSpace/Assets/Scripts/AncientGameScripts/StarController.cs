using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    public bool IsActive = false;
    private void OnMouseDown()
    {
        IsActive = !IsActive;
        var state = gameObject.GetComponentInParent<GameState>();
        if (IsActive) state.Add(gameObject);
        else state.Remove(gameObject);
        Debug.Log("!!!");
    }

    private void Update()
    {
        if (IsActive) gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        else gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
