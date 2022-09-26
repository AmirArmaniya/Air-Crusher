using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public static restart _instance;
    [SerializeField] private GameObject For_Show_Button_Restart;
    [SerializeField] private GameObject For_Show_Explosion;
    [SerializeField] private GameObject DONT_Show_Player;
    [SerializeField] private GameObject DONT_Show_JoyStick;
    [SerializeField] private GameObject DONT_Show_Button_Shoot;
    [SerializeField] private GameObject DONT_Show_Button_Pause;

    private void Awake()
    {
        _instance = this;
    }

    public static void EndGame()
    {
        moveJet1.Active = false;
        moveCamera1.Active = false;
        shoot2.Active = false;
        spwnEnemy2.Active = false;
        _instance.For_Show_Button_Restart.SetActive(true);
        _instance.For_Show_Explosion.SetActive(true);
        _instance.DONT_Show_Player.SetActive(false);
        _instance.DONT_Show_JoyStick.SetActive(false);
        _instance.DONT_Show_Button_Shoot.SetActive(false);
        _instance.DONT_Show_Button_Pause.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        moveJet1.Active = true;
        moveCamera1.Active = true;
        shoot2.Active = true;
        spwnEnemy2.Active = true;
        ScoreTextScript.score = 0;
        ammoCunter.ammo = 15;
    }
}

