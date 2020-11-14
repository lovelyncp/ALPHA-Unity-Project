using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 20.0f;
    public float xRange = 20.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create user input controls
        horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");

        // move the player forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // turns the player
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * turnSpeed);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // keep player in x bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
    }
}
