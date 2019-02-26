using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //PUBLIC exposes rb to unity so we can reference a rigidbody, Rigidbody is the type and rb is the name
    public float moveSpeed = 2000f; //initialize public variable so we can change it in the unity inspector

    // Update is called once per frame -- FixedUpdate is prefered when dealing with objects that use the Unity Physics Engine
    void FixedUpdate()
    {
      if(Input.GetKey("w")) //if user inputs a "w" key
      {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime); //Adds a force in Z direction, mult by frame delta (to make it constant no matter the fps)
      }
      if(Input.GetKey("s")) //if user inputs an "s" key
      {
        rb.AddForce(0, 0, -moveSpeed * Time.deltaTime);
      }
      if(Input.GetKey("a")) //if user inputs an "a" key
      {
        rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0);
      }
      if(Input.GetKey("d")) //if user inputs an "d" key
      {
        rb.AddForce(moveSpeed * Time.deltaTime, 0, 0);
      }
    }
}
