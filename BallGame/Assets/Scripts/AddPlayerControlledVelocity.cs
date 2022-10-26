using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class AddPlayerControlledVelocity: MonoBehaviour
{
    // Speed parameter
    [SerializeField] float speed = 0.5f;
    public float jump_speed = 0.8f;

    // Variables to select the keys to get when the force is applied

    // FixedUpdate is executed together with the physics engine
    void FixedUpdate() {

        // Build a new force vector according to 'speed'
        Vector3 v3Force_horizontal = new Vector3(speed, 0f, 0f);
        Vector3 v3Force_vertical = new Vector3(0f, 0f, speed);
        Vector3 v3Force_jump = new Vector3(0f, jump_speed , 0f);
        

        // Get keyboad positive and negative keys to move the Game Object
        if (Input.GetKey(KeyCode.UpArrow)) GetComponent<Rigidbody>().velocity += v3Force_vertical;
        if (Input.GetKey(KeyCode.DownArrow)) GetComponent<Rigidbody>().velocity -= v3Force_vertical;
        if (Input.GetKey(KeyCode.LeftArrow)) GetComponent<Rigidbody>().velocity -= v3Force_horizontal;
        if (Input.GetKey(KeyCode.RightArrow)) GetComponent<Rigidbody>().velocity += v3Force_horizontal;
        if (Input.GetKey(KeyCode.Space)) GetComponent<Rigidbody>().velocity += v3Force_jump;
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
