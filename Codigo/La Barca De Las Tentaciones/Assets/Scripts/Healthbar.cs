using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    float h;
    float w;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
    void Update()
    {
        GameObject canvas;
        canvas = GameObject.Find("Canvos");
        h = canvas.GetComponent<RectTransform>().rect.height;
        w = canvas.GetComponent<RectTransform>().rect.width;
        
        transform.position = new Vector3((float)(0.15 * w), (float)(0.9 * h), 0);

    }
}
