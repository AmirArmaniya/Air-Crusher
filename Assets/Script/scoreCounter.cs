using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    internal static int scorecounter;
    public int score = 0;
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
