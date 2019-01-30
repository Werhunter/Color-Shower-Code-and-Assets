using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour
{
    [SerializeField] private ColorRGBA colorRGBA;
    [SerializeField] private Slider slider;
    [SerializeField] private Text trackerLabel;

    private void Update()
    {
        trackerLabel.text = Mathf.RoundToInt(slider.value * 255f).ToString();
    }

    public void AddValue(int value)
    {
        Color_Script.Instance.colors[colorRGBA].value = slider.value + (float)value / 255f;
    }
}