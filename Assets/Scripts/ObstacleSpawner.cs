using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private int initAmount = 5;
    private int spawnInterval = 60;
    private int lastSpawnZ = 60;
    private int spawnAmount = 4;

    private int collectableInitAmount = 5;
    private int collectableSpawnInterval = 60;
    private int collectableLastSpawnZ = 60;
    private int collectableSpawnAmount = 5;

    private float roadWidth = 12f;

    [SerializeField]
    public List<GameObject> obstacles;

    [SerializeField]
    public List<GameObject> collectables;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            //SpawnObstacles();
        }
        for (int i = 0; i < collectableInitAmount; i++)
        {
            SpawnCollectables();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacles()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            lastSpawnZ += spawnInterval;

            // Chance is 33%
            if (Random.Range(0, 4) == 0)
            {
                GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
                float spawnX = Random.Range(-roadWidth / 2, roadWidth / 2);
                Instantiate(obstacle, new Vector3(spawnX, 0.0f, lastSpawnZ), obstacle.transform.rotation);
            }
        }
    }

    public void SpawnCollectables()
    {
        for (int i = 0; i < collectableSpawnAmount; i++)
        {
            collectableLastSpawnZ += collectableSpawnInterval;

            if (Random.Range(0, 2) == 1)
            {
                GameObject collectable = collectables[Random.Range(0, collectables.Count)];
                float spawnX = Random.Range(-roadWidth / 2, roadWidth / 2);
                Instantiate(collectable, new Vector3(spawnX, 0.4f, collectableLastSpawnZ), collectable.transform.rotation);
            }
        }
    }
}
