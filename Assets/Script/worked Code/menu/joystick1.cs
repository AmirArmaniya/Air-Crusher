using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick1 : MonoBehaviour
{
    public float speed;
    public Joystick Joystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        
        Vector3 direction = Vector3.forward * Joystick.Vertical + Vector3.right * Joystick.Horizontal
            + Vector3.down * Joystick.Horizontal + Vector3.up * Joystick.Vertical;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
        /*

        if (Joystick.Horizontal > 0)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            //Debug.Log("right");
        }

        if (Joystick.Horizontal < 0)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            //Debug.Log("left");
        }

        if (Joystick.Vertical > 0)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            //Debug.Log("up");
        }

        if (Joystick.Vertical < 0)
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            //Debug.Log("down");
        }
        */
    }
}