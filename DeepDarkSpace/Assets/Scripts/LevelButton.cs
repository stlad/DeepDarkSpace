using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{

    public enum GameTypes
    {
        Game,
        Theory,
        Test
    }

    private Text text;
    public GameTypes GameType;
    public bool IsComplete = false;
    public int LevelId;

    // Start is called before the first frame update
    void Start()
    {
        var t = transform.Find("Text").GetComponent<Text>();
        t.text = GameType.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCompleted() => IsComplete = true;

    private void OnMouseDown()
    {
        
    }
}
