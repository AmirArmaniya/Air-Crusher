using UnityEngine;
using UnityEngine.UI;

public class AmmuReloadingTimer : MonoBehaviour
{
    Text text;
    public static int timer;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Reload Time: " + timer.ToString();
    }
}
