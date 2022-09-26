using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private GameObject ButtonsInStart;

    [SerializeField] private GameObject ButtonsInStore;

    [SerializeField] private GameObject ButtonsInLeaderBoard;

    [SerializeField] private GameObject SingUp;

    [SerializeField] private GameObject Login;

    [SerializeField] private GameObject Rock_Respawner;

    [SerializeField] private GameObject player;

    [SerializeField] private GameObject buttonMute;
    [SerializeField] private GameObject buttonunmute;

    [SerializeField] private AudioSource gameSound;

    public void PauseStartMenu(bool pause)
    {
        ButtonsInStart.SetActive(pause);
    }
    public void GotoStore(bool pause)
    {
        ButtonsInStore.SetActive(pause);
    }
    public void GotoLeaderBoard(bool pause)
    {
        ButtonsInLeaderBoard.SetActive(pause);
    }
    public void goTosingup(bool pause)
    {
        SingUp.SetActive(pause);
    }
    public void goToLogin(bool pause)
    {
        Login.SetActive(pause);
    }

    public void StartButton(bool pause)
    {
        Rock_Respawner.SetActive(pause);
        player.SetActive(pause = true);
        moveJet1.Active = true;
        moveCamera1.Active = true;
        shoot2.Active = true;
        spwnEnemy2.Active = true;
        gameSound.enabled=true;
    }

    public void mute(bool pause)
    {
        AudioListener.pause = true;
        buttonMute.SetActive(false);
        buttonunmute.SetActive(true);

    }
    public void unmute(bool pause)
    {
        AudioListener.pause = false;
        buttonunmute.SetActive(false);
        buttonMute.SetActive(true);
    }
}
