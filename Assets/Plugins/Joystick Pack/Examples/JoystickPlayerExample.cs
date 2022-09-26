using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        /*
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        */

        if (variableJoystick.Horizontal > 0)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("1");
        }

        if (variableJoystick.Horizontal > 0)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("2");
        }

        if (variableJoystick.Vertical > 0)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("3");
        }

        if (variableJoystick.Vertical < 0)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("4");
        }

    }
}