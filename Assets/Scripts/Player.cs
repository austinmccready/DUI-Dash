using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpawnManager spawnManager;
    public AudioClip slurp;
    public AudioClip crash;

    private AudioSource player;

    private GameLogic gameLogic;


    public void Start() // for Drink slurp 
    {
        player = GetComponent<AudioSource>();
        player.clip = slurp;


        
    }

    private void Awake()
    {
        gameLogic = GameObject.Find("GameLogic").GetComponent<GameLogic>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("SpawnTrigger"))
        {
            Debug.Log("Entered SpawnTrigger");
            spawnManager.SpawnTriggerEntered();
        }

        if (collision.CompareTag("EnemyCar"))
        {
            player.clip = crash;
            player.Play();
            Debug.Log("You crashed!");
            gameLogic.GameOver();
        }

        if (collision.CompareTag("BoozeBottle"))
        {
            gameLogic.CollectedBoozeBottle();
            player.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("BourbonBottle"))
        {
            gameLogic.CollectedBourbonBottle();
            player.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("WaterBottle"))
        {
            gameLogic.CollectedWaterBottle();
            player.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Breathalyzer"))
        {
            gameLogic.CollectedBreathalyzer();
            Destroy(collision.gameObject);
        }
    }
}
