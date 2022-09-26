using System.Collections;
using UnityEngine;

public class spwnEnemy2 : MonoBehaviour
{
    public static bool Active = true;
    public GameObject[] rock;
    public float respawnTime = 1.0f;
    public float lifetime = 2f;
    [SerializeField] private float distance;

    private void Start()
    {
        StartCoroutine(waiter());
    }

    void Update()
    {
        //spawnEnemy();
    }

    // far spawn => 80
    // near spawn => 40/30

    public void spawnEnemy()
    {
        if (Active)
        {
            /*
            GameObject rockk = Instantiate(rock);

            int rocks_position = Random.Range(-10, 10);
            Vector3 myVector = new Vector3(Random.Range(-10, 10), 0, Camera.main.transform.position.z + 80);

            rock = Instantiate(rock, myVector, Quaternion.identity);
            Destroy(rock, lifetime);
            */

            if (ScoreTextScript.score == 50)
            {
                distance = distance - 10;
            }
            if (ScoreTextScript.score == 100)
            {
                distance = distance - 10;
            }
            if (ScoreTextScript.score == 200)
            {
                distance = distance - 10;
            }
            if (ScoreTextScript.score == 250)
            {
                distance = distance - 10;
            }
            if (ScoreTextScript.score == 300)
            {
                distance = distance - 5;
            }

            //Vector3 place = transform.position;

            int rocks_position = Random.Range(-10, 10);
            Vector3 myVector = new Vector3(Random.Range(-10, 10), 0, Camera.main.transform.position.z + distance);

            for (int x = 0; x <= rock.Length; x++)
            {
                //Instantiate(rock[rocks_Num], place, Quaternion.identity);

                Vector3 location = new Vector3(rocks_position, 0, rocks_position);
                GameObject ROCKK = Instantiate(rock[Random.Range(0, rock.Length)], myVector, Quaternion.identity);
                Destroy(ROCKK, lifetime);
            }

        }
    }

    IEnumerator waiter()
    {
        if (ScoreTextScript.score == 50)
        {
            respawnTime = 0.8f;
        }
        if (ScoreTextScript.score == 100)
        {
            respawnTime = 0.5f;
        }
        if (ScoreTextScript.score == 200)
        {
            respawnTime = 0.3f;
        }
        if (ScoreTextScript.score == 250)
        {
            respawnTime = 0.1f;
        }

        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }

    }
}
