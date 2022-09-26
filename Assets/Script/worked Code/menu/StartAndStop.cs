using UnityEngine;

public class StartAndStop : MonoBehaviour
{
    public static StartAndStop SAS;
    [SerializeField] private GameObject For_Show_Button_Pause;
    [SerializeField] private GameObject For_Show_JoyeStick;
    [SerializeField] private GameObject For_Show_Button_Shoot;
    [SerializeField] private GameObject For_Show_Player;
    [SerializeField] private GameObject For_Show_cold;
    [SerializeField] private GameObject For_Show_Information_Panel;

    [SerializeField] private GameObject DONT_show_rock_spawner_Menu;
    [SerializeField] private GameObject DONT_show_rock_2;
    [SerializeField] private GameObject STOP_Sound;

    public GameObject nothing;

    [SerializeField] private GameObject DONT_show_Button_Pause;
    [SerializeField] private GameObject DONT_show_Joystick;
    [SerializeField] private GameObject DONT_show_Button_Shoot;
    [SerializeField] private GameObject DONT_show_Player;

    private void Awake()
    {
        SAS = this;
    }

    public static void StartGame()
    {
        moveJet1.Active = true;
        moveCamera1.Active = true;
        shoot2.Active = true;
        spwnEnemy2.Active = true;
        SAS.For_Show_Button_Pause.SetActive(true);
        SAS.For_Show_JoyeStick.SetActive(true);
        SAS.For_Show_Button_Shoot.SetActive(true);
        SAS.For_Show_Player.SetActive(true);
        SAS.For_Show_cold.SetActive(true);
        SAS.For_Show_Information_Panel.SetActive(true);

        SAS.DONT_show_rock_spawner_Menu.SetActive(false);
        SAS.DONT_show_rock_2.SetActive(false);
        SAS.STOP_Sound.SetActive(false);


    }

    public static void StopGame()
    {
        moveJet1.Active = false;
        moveCamera1.Active = false;
        shoot2.Active = false;
        spwnEnemy2.Active = false;
        SAS.DONT_show_Button_Pause.SetActive(false);
        SAS.DONT_show_Joystick.SetActive(false);
        SAS.DONT_show_Button_Shoot.SetActive(false);
        SAS.DONT_show_Player.SetActive(false);
        SAS.For_Show_Information_Panel.SetActive(false);
    }

}
