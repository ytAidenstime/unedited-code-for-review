using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class movment : MonoBehaviour
{
    // for the rigid body component
    public Rigidbody rb;
    public int speed;
    public int speed2;
    public int offsetspeed;
    public int shiftslow;
    public bool canmove = true;

    // fixed update for smoothness and time delta for smoothness
    void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            // forward force
            rb.AddForce(0, 0, speed * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(speed2 * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey("a"))
            {
                rb.AddForce(-speed2 * Time.deltaTime, 0, 0);
            } 
        } else if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(0, 0, speed2 * Time.deltaTime);
            rb.AddForce(0, 0, -offsetspeed * Time.deltaTime);
        }
    }
}
