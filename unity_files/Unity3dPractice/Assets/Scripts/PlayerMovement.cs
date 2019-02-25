using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //Exposes rb to unity so we can reference a rigidbody
    // Update is called once per frame -- FixedUpdate is prefered when dealing with objects that use the Unity Physics Engine
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //Adds a force of 2000 in the Z direction, multiplied by the frame delta (to make it constant no matter the fps)
    }
}
