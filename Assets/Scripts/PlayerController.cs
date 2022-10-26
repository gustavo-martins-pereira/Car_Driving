using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the Input of the Player
        // The "Input.GetAxis("Horizontal")" catch the input of the user when press the "LEFT Key" or the "RIGHT Key", -1 to 1 respectively
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // I'll move the vehicle foward
        // The "transform" is the attribute of the object, and the "Translate" is the "Translate" in Unity
        // the "Time.deltaTime" guarantees that the code will be executed at the same time regardless of the PC processor
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); // (0, 0, 1)
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); // The "horizontalInput" defines whether the vehicle will turn left (-1) or the right (1)

        // Turn the vehicle left or right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
