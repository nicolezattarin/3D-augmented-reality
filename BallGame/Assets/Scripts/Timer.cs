using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    // Start is called before the first
    // frame update
    void Start()
    {
        // Obtain the current time.
        string currTime = "Time: 0 [s]";
        // Display the current time.
        gameObject.GetComponent<Text>().text = currTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Obtain the current time.
        string currTime = "Time: " + Mathf.Ceil(Time.time).ToString() + " [s]";
    
        // Display the current time.
        gameObject.GetComponent<Text>().text = currTime;
    }
}