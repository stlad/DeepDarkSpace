using System.Collections;
using System.Collections.Generic;
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


}
