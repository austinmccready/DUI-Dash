using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // to change scenes in unity
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    TMP_InputField playerNameField;

    public void PlayGame()
    {
        SetPlayerName(playerNameField.text);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetPlayerName(string name)
    {
        GameState gameState = ScriptableObject.CreateInstance<GameState>();
        gameState.playerName = name;
        Debug.Log("Player name is " + name);
    }
}