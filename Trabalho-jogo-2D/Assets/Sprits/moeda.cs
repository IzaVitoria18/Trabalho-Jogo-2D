using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class moeda : MonoBehaviour
{

    public int velocidadeGiro = 50;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
