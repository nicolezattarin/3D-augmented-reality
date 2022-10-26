using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OKbuttonMultiscene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //initialize button
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // The task carried out by the button
    void TaskOnClick()
    {
        if (String.Equals(SceneManager.GetActiveScene().name,"Level2"))
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single); // loads starting scene
        }
        else
        {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single); // loads next scene
        }
    }
}