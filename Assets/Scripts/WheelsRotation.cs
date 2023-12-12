using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsRotation : MonoBehaviour
{
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        // Check if the wheel is on the left or right side of the car
        bool isLeftWheel = transform.localPosition.y < 0;

        // Rotate the wheel around the Y-axis in the correct direction
        float rotation = rotationSpeed;
        if (isLeftWheel)
        {
            rotation = -rotation;
        }
        transform.Rotate(rotation, 0, 0);
    }
}