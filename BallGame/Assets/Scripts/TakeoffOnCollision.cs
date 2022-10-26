using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeoffOnCollision : MonoBehaviour
{
    [SerializeField]
    float yForce;
    [SerializeField]
    GameObject Player;

    bool hasTakenOff = false;

    private void FixedUpdate()
    {
        if (hasTakenOff)
            GetComponent<Rigidbody>().velocity += new Vector3(0, yForce, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == Player.GetComponent<Collider>())
        {
            hasTakenOff = true;
        }
    }
}
