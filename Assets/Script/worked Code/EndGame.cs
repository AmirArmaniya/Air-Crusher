using UnityEngine;

public class EndGame : MonoBehaviour
{
    public moveJet1 player;
    [SerializeField] private GameObject rock;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(rock);
            player.curentHeal--;
            if (player.curentHeal <= 0)
            {
                restart.EndGame();
            }
        }
    }
}
