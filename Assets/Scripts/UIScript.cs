using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI playerName;

    [SerializeField]
    TextMeshProUGUI distanceTraveled;

    [SerializeField]
    TextMeshProUGUI bacPercent;

    [SerializeField]
    GameState gameState;

    [SerializeField]
    GameObject gameUI;

    [SerializeField]
    GameObject gameOverMenu;

    [SerializeField]
    TextMeshProUGUI gameOverText;

    private bool displayedGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = gameState.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTraveled.text = gameState.distanceTraveled.ToString() + "m";
        bacPercent.text = gameState.bacPercent.ToString("F2") + "% BAC";

        if (gameState.isGameOver && !displayedGameOver)
        {
            displayedGameOver = true;
            DisplayGameOverMenu();
        }
    }

    private void DisplayGameOverMenu()
    {
        gameOverText.text = gameState.playerName + "\n" +
            "You drove: " + gameState.distanceTraveled + "m \n" +
            "You scored: " + gameState.score + "\n\n" +
            "You drank " + gameState.boozeCollected + " booze, " + gameState.bourbonCollected + " bourbon, and " + gameState.waterBottlesCollected + " waters";

        gameUI.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
