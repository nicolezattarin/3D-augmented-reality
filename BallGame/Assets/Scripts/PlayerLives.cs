using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    // Windows for visualizing messages
    [SerializeField]
    GameObject WinWindow;
    [SerializeField]
    GameObject LooseWindow;

    //lava and mars objects
    [SerializeField] 
    GameObject lava;
    [SerializeField] 
    GameObject mars;

    private void OnCollisionEnter(Collision collision)
    {
        // CASE LOOSE: collision with lava
        if (collision.collider == lava.GetComponent<Collider>())
        {
            LooseWindow.SetActive(true);
        }

        // CASE WIN: collsion with mars lander space capsule
        if (collision.collider == mars.GetComponent<Collider>())
        {
            WinWindow.SetActive(true);
        }
    }
}