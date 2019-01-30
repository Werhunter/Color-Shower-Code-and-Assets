using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum ColorRGBA
{
    Red, Green, Blue, Alpha
}

public class Color_Script : MonoBehaviour
{
    [SerializeField] private Slider[] sliders;
    public Dictionary<ColorRGBA, Slider> colors;

    public static Color_Script Instance { get; private set; }

    [SerializeField] private GameObject Color_Shower;




    void Awake()
    {
        Instance = this;
        colors = new Dictionary<ColorRGBA, Slider>()
        {
            { ColorRGBA.Red, sliders[0] },
            { ColorRGBA.Green, sliders[1] },
            { ColorRGBA.Blue, sliders[2] },
            { ColorRGBA.Alpha, sliders[3] },
        };
    }

    void Update()
    {

        Color Custom_Color = new Color(colors[ColorRGBA.Red].value, colors[ColorRGBA.Green].value, colors[ColorRGBA.Blue].value, colors[ColorRGBA.Alpha].value);

        Color_Shower.GetComponent<Renderer>().material.color = Custom_Color;


        if (Input.GetKeyDown(KeyCode.A))
        {
            colors[ColorRGBA.Red].value += 1f / 255f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            colors[ColorRGBA.Red].value -= 1f / 255f;
        }

    }

    public void Add_One_Red()
    {
        colors[ColorRGBA.Red].value += 1f / 255f;
    }

    public void Add_One_Green()
    {
        colors[ColorRGBA.Green].value += 1f / 255f;
    }

    public void Add_One_Blue()
    {
        colors[ColorRGBA.Blue].value += 1f / 255f;
    }

    public void Add_One_Alpha()
    {
        colors[ColorRGBA.Alpha].value += 1f / 255f;
    }

    public void Remove_One_Red()
    {
        colors[ColorRGBA.Red].value -= 1f / 255f;
    }

    public void Remove_One_Green()
    {
        colors[ColorRGBA.Green].value -= 1f / 255f;
    }

    public void Remove_One_Blue()
    {
        colors[ColorRGBA.Blue].value -= 1f / 255f;
    }

    public void Remove_One_Alpha()
    {
        colors[ColorRGBA.Alpha].value -= 1f / 255f;
    }

    public void Radomize_Color()
    {
        colors[ColorRGBA.Red].value = Random.value;
        colors[ColorRGBA.Blue].value = Random.value;
        colors[ColorRGBA.Green].value = Random.value;
    }

    public void SetColor(ColorRGBA colorRGBA, float value)
    {
        switch (colorRGBA)
        {
            case ColorRGBA.Red:
                colors[ColorRGBA.Red].value = value;
                break;
            case ColorRGBA.Green:
                colors[ColorRGBA.Green].value = value;
                break;
            case ColorRGBA.Blue:
                colors[ColorRGBA.Blue].value = value;
                break;
            case ColorRGBA.Alpha:
                colors[ColorRGBA.Alpha].value = value;
                break;
        }
    }

}
