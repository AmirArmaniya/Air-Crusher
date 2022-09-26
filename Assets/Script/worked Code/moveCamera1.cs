using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera1 : MonoBehaviour
{
    public static bool Active = true;
    public float speed;

    void Update()
    {
        if (Active)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
