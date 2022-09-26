using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public moveJet1 player;
    public Image fillImage;
    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    private void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        if (slider.value > slider.minValue && fillImage.enabled)
        {
            fillImage.enabled = true;
        }

        float fillvalue = player.curentHeal / player.maxHeal;

        if (fillvalue <= slider.maxValue / 2)
        {
            fillImage.color = Color.red;
        }
        else if (fillvalue > slider.maxValue / 2)
        {
            fillImage.color = Color.green;
        }

        slider.value = fillvalue;
    }
}