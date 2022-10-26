using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    Button myButton;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(RestartFunctino);
    }
    
    void RestartFunctino()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
    

   