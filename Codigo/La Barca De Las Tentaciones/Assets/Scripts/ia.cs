using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ia : MonoBehaviour
{
    private int caso2=0;
    public Text IA;
    float h;
    float w;
    public int caso;
    private int num = 0;
    private Vector3 spawn = new Vector3(0,0,0);
    private Vector3 spawnPos1;
    private Vector3 spawnPos2;
    private Vector3 spawnPos3;
    private Vector3 nuevo1;
    private Vector3 auxiliar1;
    private Vector3 scal_petit = new Vector3(1f, 0.25f, 0.5f);
    public Button empezar;
    public Button acc;
    public Button den;
    public Button actual;
    public Button comida_buena;
    public Button comida_neutra;
    public Button comida_mala;
    public Button ropa_buena;
    public Button ropa_neutra;
    public Button ropa_mala;
    public Button x_buena;
    public Button x_neutra;
    public Button x_mala;


    public Button s_comida_buena;
    public Button s_comida_neutra;
    public Button s_comida_mala;
    public Button s_ropa_buena;
    public Button s_ropa_neutra;
    public Button s_ropa_mala;
    public Button s_x_buena;
    public Button s_x_neutra;
    public Button s_x_mala;

    private int tiem = 49;
    private float startTime;
    private float journeyLength;
    private int probamos = 1;

    private float lerpTime = 1;
    private float clerpTime = 0;
    bool moved = false;
    

   

    // Start is called before the first frame update
    void Start()
    {
        acc.gameObject.SetActive(true);
        den.gameObject.SetActive(true);
        //nuevo1 = actual.transform.position;
        acc.onClick.AddListener(empezar_game);
    }
    void Update()
    {
        if (tiem == 0)
        {         
            tiem = 2;
        }
        if (tiem == 2)
        {
            
            GameObject canvas;
            canvas = GameObject.Find("Canvos");
            h = canvas.GetComponent<RectTransform>().rect.height;
            w = canvas.GetComponent<RectTransform>().rect.width;
            spawnPos1 = new Vector3((float)(0.9 * w), (float)(0.85 * h), 0);
            spawnPos2 = new Vector3((float)(0.9 * w), (float)(0.5 * h), 0);
            spawnPos3 = new Vector3((float)(0.9 * w), (float)(0.15 * h), 0);

            float wcarta = 275;

            nuevo1 = new Vector3((float)(0.5 * w), (float)(0.6 * h), 0);
            clerpTime += Time.deltaTime;
            if (clerpTime >= lerpTime)
            {
                clerpTime = lerpTime;
            }
            float perc = clerpTime / lerpTime;
            // casos cartas buenas
            if (caso == 0)
            {              
                if (caso2 == 0)
                {
                    comida_buena.transform.position = Vector3.Lerp(spawn, nuevo1, perc);
                    s_comida_buena.gameObject.SetActive(true);

                    if (comida_buena.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_comida_buena.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;

                    }
                }
                else if (caso2 == 1)
                {
                    ropa_buena.transform.position = Vector3.Lerp(spawn, nuevo1, perc);

                    s_ropa_buena.gameObject.SetActive(true);
                    if (ropa_buena.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_ropa_buena.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
                else if (caso2 == 2)
                {
                    x_buena.transform.position = Vector3.Lerp(spawn, nuevo1, perc);

                    s_x_buena.gameObject.SetActive(true);
                    if (x_buena.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_x_buena.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
            }
            // casos cartas neutras
            else if (caso == 1)
            {
                if (caso2 == 0)
                {
                    comida_neutra.transform.position = Vector3.Lerp(spawn, nuevo1, perc);
                    s_comida_neutra.gameObject.SetActive(true);
                    if (comida_neutra.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_comida_neutra.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
                else if (caso2 == 1)
                {
                    ropa_neutra.transform.position = Vector3.Lerp(spawn, nuevo1, perc);
                    s_ropa_neutra.gameObject.SetActive(true);
                    if (ropa_neutra.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_ropa_neutra.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
                else if (caso2 == 2)
                {
                    x_neutra.transform.position = Vector3.Lerp(spawn, nuevo1, perc);
                    s_x_neutra.gameObject.SetActive(true);
                    if (x_neutra.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_x_neutra.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
            }
            // casos cartas malas
            else if (caso == 2)
            {
                if (caso2 == 0)
                {
                    comida_mala.transform.position = Vector3.Lerp(spawn, nuevo1, perc);
                    s_comida_mala.gameObject.SetActive(true);
                    if (comida_mala.transform.position == nuevo1)
                    {                     
                        caso2 = 5;
                        s_comida_mala.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
                else if (caso2 == 1)
                {
                    ropa_mala.transform.position = Vector3.Lerp(spawn, nuevo1, perc);
                    s_ropa_mala.gameObject.SetActive(true);
                    if (ropa_mala.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_ropa_mala.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
                else if (caso2 == 2)
                {
                    x_mala.transform.position = Vector3.Lerp(spawn, nuevo1, perc);

                    s_x_mala.gameObject.SetActive(true);
                    if (x_mala.transform.position == nuevo1)
                    {
                        caso2 = 5;
                        s_x_mala.gameObject.SetActive(true);
                        acc.gameObject.SetActive(false);
                        tiem = 55;
                    }
                }
            }
        }
    }
    void empezar_game()
    {
        Vector3 scal_petit_1 = new Vector3(0.6f, 0.3f, 1f);
        actual.transform.localScale = scal_petit_1;
        IA.gameObject.SetActive(true);
        probamos = 0;
        comida_buena.transform.position = spawnPos1;
        comida_neutra.transform.position = spawnPos2;
        comida_mala.transform.position = spawnPos3;
        ropa_buena.transform.position = spawnPos1;
        ropa_neutra.transform.position = spawnPos2;
        ropa_mala.transform.position = spawnPos3;
        x_buena.transform.position = spawnPos1;
        x_neutra.transform.position = spawnPos2;
        x_mala.transform.position = spawnPos3;

        den.gameObject.SetActive(false);

        comida_buena.gameObject.SetActive(false);
        comida_neutra.gameObject.SetActive(false);
        comida_mala.gameObject.SetActive(false);

        ropa_buena.gameObject.SetActive(false);
        ropa_neutra.gameObject.SetActive(false);
        ropa_mala.gameObject.SetActive(false);

        x_buena.gameObject.SetActive(false);
        x_neutra.gameObject.SetActive(false);
        x_mala.gameObject.SetActive(false);

        caso2 = Random.Range(0, 3);

        // que salga del medio de las 3

        Vector3 scal_petit = new Vector3(0.7f, 0.6f, 1f);
        //activamos la carta
        if (caso == 0)
        {
            auxiliar1 = spawnPos1;
            if (caso2 == 0)
            {
                comida_buena.transform.localScale = scal_petit;
                comida_buena.gameObject.SetActive(true);              
            }
            else if (caso2 == 1)
            {
                ropa_buena.transform.localScale = scal_petit;
                ropa_buena.gameObject.SetActive(true);
            }
            else if (caso2 == 2)
            {
                x_buena.transform.localScale = scal_petit;
                x_buena.gameObject.SetActive(true);
            }


        }
        // casos cartas neutras
        else if (caso == 1)
        {
            auxiliar1 = spawnPos2;
            if (caso2 == 0)
            {
                comida_neutra.transform.localScale = scal_petit;
                comida_neutra.gameObject.SetActive(true);
            }
            else if (caso2 == 1)
            {
                ropa_neutra.transform.localScale = scal_petit;
                ropa_neutra.gameObject.SetActive(true);
            }
            else if (caso2 == 2)
            {
                x_neutra.transform.localScale = scal_petit;
                x_neutra.gameObject.SetActive(true);

            }

        }
        // casos cartas malas
        else if (caso == 2)
        {
            auxiliar1 = spawnPos3;
            if (caso2 == 0)
            {
                comida_mala.transform.localScale = scal_petit;
                comida_mala.gameObject.SetActive(true);

            }
            else if (caso2 == 1)
            {
                ropa_mala.transform.localScale = scal_petit;
                ropa_mala.gameObject.SetActive(true);

            }
            else if (caso2 == 2)
            {
                x_mala.transform.localScale = scal_petit;
                x_mala.transform.gameObject.SetActive(true);
            }

        }
        clerpTime = 0;
        tiem = 0;
    }
}
