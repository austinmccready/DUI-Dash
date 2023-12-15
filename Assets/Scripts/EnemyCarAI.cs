using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarAI : MonoBehaviour
{
    private float movementSpeed = 5f;
    private Rigidbody enemyRb;
    private GameObject player;
    private float reactDistance = 50f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        Vector3 lookDirection;

        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

        if (distance <= reactDistance)
        {
            if (distance > 5f)
            {
                targetPos.z += (distance / 2f);
            }

            lookDirection = (targetPos - transform.position).normalized;
            enemyRb.AddForce(lookDirection * movementSpeed);
        }
        else
        {
            lookDirection = (targetPos - transform.position).normalized;
            enemyRb.AddForce(lookDirection * movementSpeed * 0.2f);
        }

        // Rotate the enemy car to face the direction of movement
        Quaternion toRotation = Quaternion.LookRotation(lookDirection, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 5f);

        if ((transform.position.z - player.transform.position.z) < -3f)
        {
            Destroy(gameObject);
        }
    }
}
