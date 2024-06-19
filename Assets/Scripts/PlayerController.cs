using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 40f;
    private float turnSpeed = 120f;
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotate vehicle left/right
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput); 
    }
}
