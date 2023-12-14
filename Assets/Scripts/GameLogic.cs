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

        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameState.distanceTraveled = Mathf.RoundToInt(player.transform.position.z);
    }

    public void CollectedBoozeBottle()
    {
        gameState.bacPercent += 0.01f;
    }

    public void CollectedBourbonBottle()
    {
        gameState.bacPercent += 0.02f;
    }

    public void CollectedWaterBottle()
    {
        gameState.bacPercent -= 0.0125f;
    }

    public void CollectedBreathalyzer()
    {

    }
}
