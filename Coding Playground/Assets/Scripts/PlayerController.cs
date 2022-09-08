using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // PC Stats
    public float speed = 10.00f;
    public float rotSpeed = 50.0f;

    public Rigidbody playerRb;
    // Input Variables
    float hInput;
    float vInput;

    
    // Update is called once per frame
    void Update()
    {
      // Get Keyboard inputs
      hInput = Input.GetAxis("Horizontal");
      vInput = Input.GetAxis("Vertical");
      //Move the PC forward and backward
      transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);
      //Rotate PC left and right
      transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); 

    }
}
