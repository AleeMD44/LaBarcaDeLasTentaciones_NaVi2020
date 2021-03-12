using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Foodbar : MonoBehaviour
{
    public Slider slider;
    
    float h;
    float w;

    public void SetMaxFood(int food)
    {
        slider.maxValue = 100;
        slider.value = food;
    }

    public void SetFood(int food)
    {
        slider.value = food;
    }

    void Update()
    {
        GameObject canvas;
        canvas = GameObject.Find("Canvos");
        h = canvas.GetComponent<RectTransform>().rect.height;
        w = canvas.GetComponent<RectTransform>().rect.width;
        
        transform.position = new Vector3((float)(0.15 * w), (float)(0.8 * h), 0);

    }
    

}
