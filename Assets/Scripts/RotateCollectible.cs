using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectible : MonoBehaviour
{
    private float rotationSpeed = 120f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
