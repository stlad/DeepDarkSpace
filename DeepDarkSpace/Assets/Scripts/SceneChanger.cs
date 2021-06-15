using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void ChangeScene()
    {
        var levelType = CurrentCondition.LevelType;
        switch ((int)levelType)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            default:
                Debug.Log("CannotLoad");
                break;
        }
    }


    public void LoadScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void LoadSceneFromCurrentCondition()
    {
        SceneManager.LoadScene((int)CurrentCondition.LevelType);
    }

    public void LoadNextScene()
    {
        CurrentCondition.LevelId++;
        var type = CurrentCondition.AllLevels.Where(n => n.Item1 == CurrentCondition.LevelId).First();
        if (type == null)
        {
            SceneManager.LoadScene(1);
            return;
        }
        CurrentCondition.LevelType = type.Item2;
        SceneManager.LoadScene((int)type.Item2);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
