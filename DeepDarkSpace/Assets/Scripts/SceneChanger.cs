using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int Id;

    public void ChangeScene()
    {
        SceneManager.LoadScene($"level{Id}");
    }
}
