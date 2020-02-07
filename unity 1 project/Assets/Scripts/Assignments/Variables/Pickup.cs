using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int pointsToAdd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        // Check to see if trigger detected player
        if(other.gameObject.CompareTag("Player")){

            ScoreManager.AddPoints (pointsToAdd);
            Destroy (gameObject);
        }
    }
}
