using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime* speed*forwardInput);
        transform.Rotate(Vector3.up,  Time.deltaTime* turnSpeed * horizontalInput); //rotates the car instead of sliding when turned right

    }
}
