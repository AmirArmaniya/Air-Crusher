using UnityEngine;
using FiroozehGameService.Core;

public class SaveScore : MonoBehaviour
{
    public moveJet1 player;

    void Start()
    {
        if (player.curentHeal == 0)
        {
            Debug.Log("SAveeeeeeeeeeeeeeeeeeeeeeeee");
            GameService.Leaderboard.SubmitScore("6137e6c7d8e2be00198cd75f", ScoreTextScript.score);
        }
    }
}
