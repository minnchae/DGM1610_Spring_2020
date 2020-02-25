using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    private Rigidbody enemyRb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        //target = GameObject.Find("Player").transform; // Transform.Translate example
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        
    }

    void FixedUpdate(){
        //change velocity
            //enemyRb.velocity = player * moveSpeed;
        //add force
            enemyRb.AddForce((player.transform.position - transform.position).normalized * moveSpeed);

        //Move position
            //enemyRb.MovePosition((player.transform.position - transform.position).normalized * moveSpeed);

    }
    // homework for feb 24/25 play around with velocity, force and move position in 
    //order to figure out how to move objects in different ways. 
}


