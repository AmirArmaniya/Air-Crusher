using UnityEngine;

public class destroye : MonoBehaviour
{
    public GameObject rock;
    [SerializeField] private AudioSource Stone_explosion_Sound;

    private void Start()
    {
        Stone_explosion_Sound.enabled = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            ScoreTextScript.score += 1;
            Destroy(rock);

            Stone_explosion_Sound.PlayOneShot(Stone_explosion_Sound.clip);
        }
    }
}
