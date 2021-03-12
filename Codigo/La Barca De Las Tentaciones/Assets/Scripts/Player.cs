using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Healthbar healthbar;
    public Foodbar foodbar;
    public int vida;
    public int comida;
    public int karma;
    public int vidamax = 100;
    public Text Vida;
    public Text Comida;

    void Start()
    {
        vida = 100;
        comida = 20;
        karma = 0;
        healthbar.SetMaxHealth(vidamax);
        foodbar.SetMaxFood(100);
    }

    void Update()
    {
        Vida.text = "Vida : " + vida;
        Comida.text = "Comida : " + comida;
        healthbar.SetHealth(vida);
        foodbar.SetFood(comida);
    }
    
}
