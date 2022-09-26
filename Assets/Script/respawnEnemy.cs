using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform _player;
    //[SerializeField] private GameObject _groundPrefab;
    [SerializeField] private GameObject[] _obstacles;

    public float lifetime = 2f;

    //private List<GameObject> _grounds;
    private float _groundDefaultZ;
    //private int _moveCounter = 0;

    void Update()
    { 
        spawn();
    }

    void spawn()
    {
        Debug.Log("hello");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("hello");
            //_grounds.Add(Instantiate(_groundPrefab, new Vector3(0, 0, _groundDefaultZ * i), Quaternion.identity));
            if (i > 3)
            {
                Debug.Log("h1");
                if (i % 2 == 0)
                { 
                    Vector3 location = new Vector3(0, 0, Random.Range((_groundDefaultZ * i) - 3, (_groundDefaultZ * i) + 3));
                    Instantiate(_obstacles[Random.Range(0, _obstacles.Length)], location, Quaternion.identity); 
                }
            }
        }
    }

    IEnumerable ie()
    {
        yield return new WaitForSecondsRealtime(10);
    }
}