using UnityEngine;
using FiroozehGameService.Core;
using UnityEngine.UI;

public class showLeaderboard : MonoBehaviour
{
    Text text;
    FiroozehGameService.Models.BasicApi.LeaderBoardDetails _leaderboard;
    FiroozehGameService.Models.BasicApi.Score _score;

    string first;

    async public void Start()
    {
        text = GetComponent<Text>();

        _leaderboard = await GameService.Leaderboard.GetLeaderBoardDetails("6137e6c7d8e2be00198cd75f", 50, false);
        Debug.Log(_leaderboard.Scores);

        _score = await GameService.Leaderboard.GetCurrentPlayerScore("6137e6c7d8e2be00198cd75f");
        Debug.Log(_score.Value);

        int leaderboard = _leaderboard.Scores.Count;
        int score = _score.Value;
        
        text.text = "You rank is " + leaderboard.ToString() + " You score is " + score.ToString() ;

        foreach (var lead in _leaderboard.Scores)
        {
            Debug.Log(" Lead : " + lead.Submitter.Name + " lead Rank : " + lead.Rank + " Lead Score : " + lead.Value + " Tries : " + lead.Tries);

            /*
            text.text = "You rank is " + leaderboard.ToString() + " You score is " + score.ToString()
            + "\n" + "\n" + " Lead : " + lead.Submitter.Name + " lead Rank : " + lead.Rank + " Lead Score : " + lead.Value + " Tries : " + lead.Tries;

            /*
            if (System.Convert.ToBoolean(lead.Rank == 1))
            {
                text.text = "first rank " + leaderboard.ToString();
            } 
            */
            
        }
    }
}