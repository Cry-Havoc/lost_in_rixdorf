using Completed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/LevelParameters", order = 1)]

public class LevelParameters : ScriptableObject
{
    public string levelName;
    public BoardManager.Count numberOfWalls;
    public BoardManager.Count numberOfEnemies;
    public BoardManager.Count numberOfPickups; 
}
