using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot1 : MonoBehaviour
{
    public GameObject _bullet;
    public Transform _spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Gun();
    }
    public void Gun()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bullet, _spawnPoint);
        }
    }
}
