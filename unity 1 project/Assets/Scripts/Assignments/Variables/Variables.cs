﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declaration

    public float amount;
    public float money;
    public float cost;


    //Declaration and Initialization
    int cookieBox = 10;

    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount,money,cost);
        
     
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Cookies(float amount, float money, float cost)   
    {
        float total;

        total = money - cost * amount;
        print(total);
    }
}
