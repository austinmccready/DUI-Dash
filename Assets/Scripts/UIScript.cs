using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI playerName;

    [SerializeField]
    GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = gameState.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
