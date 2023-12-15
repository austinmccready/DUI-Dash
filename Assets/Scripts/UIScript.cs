using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI playerName;

    [SerializeField]
    TextMeshProUGUI distanceTraveled;

    [SerializeField]
    TextMeshProUGUI bacPercent;

    [SerializeField]
    TextMeshProUGUI score;

    [SerializeField]
    GameState gameState;

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
        score.text = gameState.score.ToString("N0") + "pts";

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
            "You scored: " + gameState.score + " points\n\n" +
            "You drank " + gameState.boozeCollected + " booze, " + gameState.bourbonCollected + " bourbon, and " + gameState.waterBottlesCollected + " waters";

        playerName.text = "";
        distanceTraveled.text = "";
        bacPercent.text = "";
        score.text = "";
        gameOverMenu.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
