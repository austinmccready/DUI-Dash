using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "gameState", menuName = "State/DuiDashGameState")]
public class GameState : ScriptableObject
{
    public string playerName { get; set; }
    public float bacPercent { get; set; }
    public float scoreMultiplier { get; set; }
    public float score { get; set; }
    public float distanceTraveled { get; set; }
    public int boozeCollected { get; set; }
    public int bourbonCollected { get; set; }
    public int waterBottlesCollected { get; set; }
    public bool isGameOver { get; set; }
}