using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_rock_automaticly : MonoBehaviour
{

    public GameObject[] rock;

    // Update is called once per frame
    void Update()
    {
        respawnEnemy();
    }
    void respawnEnemy()
    {
        Vector3 place = transform.position;

        int rocks_position = Random.Range(-10, 10);
        Vector3 myVector = new Vector3(Random.Range(-10, 10), 0, Random.Range(10, 100));

        for (int x = 0; x <= rock.Length; x++)
        {
            //Instantiate(rock[rocks_Num], place, Quaternion.identity);

            Vector3 location = new Vector3(rocks_position, 0, rocks_position);
            Instantiate(rock[Random.Range(0, rock.Length)], myVector, Quaternion.identity);
        }
    }

}
