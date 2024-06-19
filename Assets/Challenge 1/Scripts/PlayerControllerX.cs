using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 60f;
    public float rotationSpeed = 100f;
    public float verticalInput = 20f;
    public float horizontalInput = 20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        // get the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        // tilt the plane lef/right based on left/right arrow keys
        transform.Rotate(Vector3.up *  rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
