using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // I'll move the vehicle foward
        // The "transform" is the attribute of the object, and the "Translate" is the "Translate" in Unity
        // the "Time.deltaTime" guarantees that the code will be executed at the same time regardless of the PC processor
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // (0, 0, 1)
    }
}
