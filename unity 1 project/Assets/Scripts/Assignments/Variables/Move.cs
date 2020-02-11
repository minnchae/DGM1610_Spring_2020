using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        // forward and back movement
        horizontalInput = Input.GetAxis("Horizontal");
        // left and right movement
        transform.Translate(Vector3.forward*speed*Time.deltaTime*verticalInput);
        transform.Rotate(Vector3.up*turnSpeed*Time.deltaTime*horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position , projectilePrefab.transform.rotation);

        }

    }

    // Detect collision with another object
    
    
    }