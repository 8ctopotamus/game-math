using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SetBits : MonoBehaviour
{
    int bSequence = 8 + 2 + 1;
    // Note: You're basically setting binary: 1000 + 10 + 1
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Convert.ToString(bSequence, 2));    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}