using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameLogic gameLogic;

    private void Awake()
    {
        gameLogic = GameObject.Find("GameLogic").GetComponent<GameLogic>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("BoozeBottle"))
        {
            gameLogic.CollectedBoozeBottle();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("BourbonBottle"))
        {
            gameLogic.CollectedBourbonBottle();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("WaterBottle"))
        {
            gameLogic.CollectedWaterBottle();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Breathalyzer"))
        {
            gameLogic.CollectedBreathalyzer();
            Destroy(collision.gameObject);
        }
    }
}
