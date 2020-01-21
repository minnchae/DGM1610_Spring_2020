using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variableshomework1 : MonoBehaviour
{
    float waterBottle;
    float waterAmount;
    float waterCost;

    // Start is called before the first frame update
    void Start()
    {
        Water(waterAmount,waterCost,waterBottle);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Water(float waterAmount, float waterCost, float waterBottle);
    {float total;

    total = waterAmount - waterCost * waterBottle;
    print(total);


    }
}
