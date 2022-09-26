using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInCamera : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -12f, 12f),
            Mathf.Clamp(transform.position.y, -5f, 9f), transform.position.z);
    }
}
