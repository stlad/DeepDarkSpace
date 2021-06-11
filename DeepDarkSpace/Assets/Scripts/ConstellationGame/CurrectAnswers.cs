using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CurrectAnswers : MonoBehaviour
{
    public static Dictionary<int, HashSet<int>> CurrectEdges = new Dictionary<int, HashSet<int>>();
    public GameObject Game;
    public GameObject CurrentCond;
    public GameObject NextLevelButton;
    private void Start()
    {
        //созвездие большрй медведицы
        //CurrectEdges[0] = new HashSet<int>(new int[1] { 1 });
        //CurrectEdges[1] = new HashSet<int>(new int[2] { 0, 2 });
        //CurrectEdges[2] = new HashSet<int>(new int[2] { 1, 3 });
        //CurrectEdges[3] = new HashSet<int>(new int[3] { 2, 4, 6 });
        //CurrectEdges[4] = new HashSet<int>(new int[2] { 3, 5 });
        //CurrectEdges[5] = new HashSet<int>(new int[2] { 6, 4 });
        //CurrectEdges[6] = new HashSet<int>(new int[2] { 3, 5 });

        //близнецы
        CurrectEdges[0] = new HashSet<int>(new int[1] { 2 });
        CurrectEdges[1] = new HashSet<int>(new int[1] { 2 });
        CurrectEdges[2] = new HashSet<int>(new int[4] {1,0,3,7});
        CurrectEdges[3] = new HashSet<int>(new int[2] {2,4 });
        CurrectEdges[4] = new HashSet<int>(new int[4] { 3,5,6,12 });
        CurrectEdges[5] = new HashSet<int>(new int[1] {4  });
        CurrectEdges[6] = new HashSet<int>(new int[1] { 4 });
        CurrectEdges[7] = new HashSet<int>(new int[3] {2,8,10 });
        CurrectEdges[8] = new HashSet<int>(new int[2] { 7,9 });
        CurrectEdges[9] = new HashSet<int>(new int[1] { 8 });
        CurrectEdges[10] = new HashSet<int>(new int[2] { 7,11 });
        CurrectEdges[11] = new HashSet<int>(new int[1] {10  });
        CurrectEdges[12] = new HashSet<int>(new int[3] { 4,13,14 });
        CurrectEdges[13] = new HashSet<int>(new int[1] { 12 });
        CurrectEdges[14] = new HashSet<int>(new int[2] { 12,15 });
        CurrectEdges[15] = new HashSet<int>(new int[1] { 14 });
    }

    public bool CheckCurrection()
    {
        var edges = Game.GetComponent<GameState>().Edges;
        foreach (var key in CurrectEdges.Keys)
        {
            if (!edges.ContainsKey(key)) return false;
            if (CurrectEdges[key].Count != edges[key].Count) return false;

            foreach (var node in CurrectEdges[key])
            {
                if (!edges[key].Contains(node)) return false;
            }
        }
        return true;
    }

    public void SetCompletedLevelIfCorrect()
    {
        if (CheckCurrection())
        {
            gameObject.GetComponent<Image>().color = Color.green;
            CurrentCond.GetComponent<CurrentCondition>().SetLevelCompleted();
            NextLevelButton.SetActive(true);
        }
        else gameObject.GetComponent<Image>().color = Color.red;
    }
}
