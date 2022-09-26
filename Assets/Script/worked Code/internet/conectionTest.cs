using UnityEngine;
using FiroozehGameService.Core;
using UnityEngine.UI;

public class conectionTest : MonoBehaviour
{
    public static conectionTest _instance;

    public InputField singupNickName, singupEmail, singupPassword;
    public InputField loginEmail, loginPassword;
    public Text LoginErr;

    [SerializeField] private GameObject activate_leaderBoard;

    private void Awake()
    {
        _instance = this;
    }

    async void Start()
    {
        GameService.IsAuthenticated();

        //baad az eneteshar in khat paiin bayad delet beshe
        await GameService.LoginOrSignUp.LoginAsGuest();
        if (GameService.IsAuthenticated())
            Debug.Log("IsAuthenticated");
        else
            Debug.Log("First Init!");

        //  singup();
        //  Login();

        Debug.Log("IsAuthenticated_ " + GameService.IsAuthenticated());
        Debug.Log("PING_ " + GameService.GSLive.GetPing());
        Debug.Log("Leaderboard_ " + await GameService.Leaderboard.GetLeaderBoards());
        Debug.Log("Scroe_ " + await GameService.Leaderboard.GetCurrentPlayerScore("6137e6c7d8e2be00198cd75f"));

        /*
        if (GameService.IsAuthenticated() == true)
        {
            _instance.activate_leaderBoard.SetActive(true);
        }
        */
    }

    async void singup()
    {
        var nickName = singupNickName.text.Trim();
        var email = singupEmail.text.Trim();
        var pass = singupPassword.text.Trim();

        if (string.IsNullOrEmpty(nickName)
            && string.IsNullOrEmpty(email)
            && string.IsNullOrEmpty(pass))
            LoginErr.text = "Invalid Input!";
        else
            await GameService.LoginOrSignUp.SignUp(nickName, email, pass);
    }

    async void Login()
    {
        var loginemail = loginEmail.text.Trim();
        var loginpass = loginPassword.text.Trim();
        if (string.IsNullOrEmpty(loginemail) && string.IsNullOrEmpty(loginpass))
            LoginErr.text = "Invalid Input!";
        else
            await GameService.LoginOrSignUp.Login(loginemail, loginpass);
    }

}
