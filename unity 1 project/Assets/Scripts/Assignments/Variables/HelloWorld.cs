using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string hello="Goodbye to you";
    string to="all of the small ones";
    string you="have fun in the world";

    string goodbye="Hello my friends";
    string all="I am here to help you";
    string ofYou="come follow me";

    // Start is called before the first frame update
    void Start()
    {
        print(hello+" "+to+" "+you);

        print(goodbye+" "+all+" "+ofYou);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
