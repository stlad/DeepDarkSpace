using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

//в этом классе содержится информация о текущем положении пользователя в пространстве игры

public class CurrentCondition : MonoBehaviour
{
    public enum LevelTypes
    {
        None = 0,
        Theory = 1,
        Test = 2,
        ConstellationGame = 3,
        NavigationGame = 4,
        TelescopeGame = 5,
        Menu = 6
    }
    public enum AgeTypes
    {
        None = 0,
        Ancient = 1,
        Middle = 2,
        Modern = 3,
    }

    public static AgeTypes AgeType = AgeTypes.Ancient;
    public static LevelTypes LevelType = LevelTypes.Theory;
    public static int LevelId = 0;

    public static HashSet<Tuple<AgeTypes, int>> CompletedLevels = new HashSet<Tuple<AgeTypes, int>>();
    public static HashSet<Tuple<int, LevelTypes, AgeTypes>> AllLevels = new HashSet<Tuple<int, LevelTypes, AgeTypes>>();
    public static string GetFullLevelId()
    {
        return $"{(int)AgeType}_{LevelId}";
    }

    public void SetLevelCompleted()
    {
        var tuple = Tuple.Create(AgeType, LevelId);
        Debug.Log($"{tuple.ToString()} {CompletedLevels.Count}");
        CompletedLevels.Add(tuple);
    }

    public void SetNextLevel()
    {
        LevelId++;
    }
}
