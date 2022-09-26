using UnityEngine;
using UnityEngine.UI;

public class ammoCunter : MonoBehaviour
{
    Text text;
    public static int ammo = shoot2.overheattimeRange;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Ammo: " + ammo.ToString();
    }
}
