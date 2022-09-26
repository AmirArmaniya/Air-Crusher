using UnityEngine;
using FiroozehGameService.Core;

public class Leaderboard : MonoBehaviour
{
    public static Leaderboard _instance;
    [SerializeField] private GameObject activate_leaderBoard;

    private void Awake()
    {
        _instance = this;
    }

    async void Start()
    {

        GameService.IsAuthenticated();
        //baad az eneteshar in khat paiin bayad delet beshe
        //await GameService.LoginOrSignUp.LoginAsGuest();


        if (GameService.IsAuthenticated())
            Debug.Log("IsAuthenticated");
        else
            Debug.Log("First Init!");

        Debug.Log("IsAuthenticated_ " + GameService.IsAuthenticated());
        Debug.Log("PING_ " + GameService.GSLive.GetPing());
        Debug.Log("Scroe_ " + await GameService.Leaderboard.GetCurrentPlayerScore("6137e6c7d8e2be00198cd75f"));


        if (GameService.IsAuthenticated() == true)
        {
            _instance.activate_leaderBoard.SetActive(true);
        }

    }
}
