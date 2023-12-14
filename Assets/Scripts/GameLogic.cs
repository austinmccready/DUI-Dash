using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;

    private GameObject player;

    /**
     * 0.00 - 0.03 BAC, there is no loss of coordination; this is the legal BAC for driving in most states.
     * 0.08 is the legal limit for driving under the influence in the United States.
     */

    // Start is called before the first frame update
    void Start()
    {
        gameState.scoreMultiplier = 1;
        gameState.bacPercent = 0.02f;
        gameState.score = 0;
        gameState.distanceTraveled = 0;
        gameState.boozeCollected = 0;
        gameState.bourbonCollected = 0;
        gameState.waterBottlesCollected = 0;
        gameState.isGameOver = false;

        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameState.distanceTraveled = Mathf.RoundToInt(player.transform.position.z);

        // Constantly check if BAC gets to <= 0.00% (GAME OVER)
        if (gameState.bacPercent <= 0.00f)
        {
            GameOver();
        }
    }

    public void CollectedBoozeBottle()
    {
        gameState.bacPercent += 0.01f;
        gameState.boozeCollected += 1;
    }

    public void CollectedBourbonBottle()
    {
        gameState.bacPercent += 0.02f;
        gameState.bourbonCollected += 1;
    }

    public void CollectedWaterBottle()
    {
        gameState.bacPercent -= 0.0125f;
        gameState.waterBottlesCollected += 1;
    }

    public void CollectedBreathalyzer()
    {

    }

    public void GameOver()
    {
        gameState.isGameOver = true;
        // play crash sound
        
        //make screen black
        // pause main game stuff so score, distance, stats etc. are halted

            // ui pops up, "Wasted" (gives different text based on what happened i.e. "Wasted", "Hangover" (BAC hits 0.00%), "Crashed" (crashed, duh))
            // DRIVE AGAIN?  RETURN TO MENU?
    }
}
