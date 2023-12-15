using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyCarAI : MonoBehaviour
{
    private float movementSpeed = 75f;
    private Rigidbody enemyRb;
    private GameObject player;
    private float reactDistance = 150f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosPastPlayer = new Vector3(transform.position.x, transform.position.y, transform.position.z - 20);
        float distance = Vector3.Distance(player.transform.position, transform.position);
        Vector3 lookDirection;

        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);


        if (distance <= reactDistance && distance > 50f)
        {
           
            lookDirection = (targetPos - transform.position).normalized;
            transform.Translate(-1 * lookDirection * (movementSpeed/2*Time.deltaTime));
        }
        else
        {
            
            lookDirection = (targetPosPastPlayer - transform.position).normalized;
            transform.Translate(new Vector3(0,0,1) * (movementSpeed * Time.deltaTime));
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
