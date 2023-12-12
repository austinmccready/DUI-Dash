using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlotSpawner : MonoBehaviour
{
    private int initAmount = 5;

    // plot sizes are 60m by default
    private float plotSize = 60f;

    // left and right sides of road
    private float xPosLeft = -38.25f;
    private float xPosRight = 38.25f;

    private float lastZPos = 15f;

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnSidePlot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSidePlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 0.025f, zPos), Quaternion.Euler(0, 270, 0));
        Instantiate(plotRight, new Vector3(xPosRight, 0.025f, zPos), Quaternion.Euler(0, 90, 0));

        lastZPos += plotSize;
    }
}
