using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Card : MonoBehaviour
{
    private Player player;
    private Button cartaFinal;
    public Text t;

    private bool comida = false;
    private bool ropa = false;
    private bool x = false;
    private Vector3 nuevo1 = new Vector3(443, 272, 0);
    private Vector3 spawnPos1 = new Vector3(875, 400, 0);
    private Vector3 spawnPos2 = new Vector3(875, 300, 0);
    private Vector3 spawnPos3 = new Vector3(875, 200, 0);
    private Vector3 scal_gran = new Vector3(1f, -0.25f, -0.5f);
    private Vector3 scal_pet = new Vector3(1f, 0.25f, 0.5f);

    public int karmaMod;
    public int comidaMod;
    public int vidaMod;
    public float probabilidad;

    public Text titulo;
    public Text cuerpo;

    private float speed = 0.01F;
    public Button REAL;
    public Button C_B;

    public Button C_N;
    public Button C_M;

    public Button R_B;
    public Button R_N;
    public Button R_M;

    public Button X_B;
    public Button X_N;
    public Button X_M;


    public Button comida_buena;
    public Button comida_neutra;
    public Button comida_mala;
    public Button ropa_buena;
    public Button ropa_neutra;
    public Button ropa_mala;
    public Button x_buena;
    public Button x_neutra;
    public Button x_mala;

    private Button central;


    public Button aux1; //acceptar
    public Button aux2; // rechazar
    public Button aux3; // pasar turno
    private Vector3 auxiliar1;
    private Vector3 v1;

    private int tiempo = 99;
    private float startTime;
    private float journeyLength;


    private float lerpTime = 1;
    private float clerpTime = 0;

    public void setKarma (int k)
    {
        karmaMod = k;
    }
    public void setComida(int c)
    {
        comidaMod = c;
    }
    public void setVida(int v)
    {
        vidaMod = v;
    }
    public void setProbabilidad(float p)
    {
        probabilidad = p;
    }
    public void setTitulo(string t)
    {
        titulo.text = t;
    }
    public void setCuerpo(string cu)
    {
        cuerpo.text = cu;
    }

    
}
