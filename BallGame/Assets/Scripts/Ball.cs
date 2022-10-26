using System;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class Ball : MonoBehaviour
{
    /////////////////////////////////
    // FUNCTIONS
    /////////////////////////////////
    // Method to manage the collision with another object
    private void OnCollisionEnter(Collision collision) {
        // select a color with the function and change the material property
        Color randomColor = SelectRandomColor();
        GetComponent<Renderer>().material.color = randomColor; 
    }

    // Update is called once per frame
    private Color SelectRandomColor() {
        // create a new color picking random values of red, green and blue
        Color newColor = new Color( UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f) );
        // return the created color
        return newColor; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
