using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pa : MonoBehaviour
{
    private float h;
    private float w;
    private Vector3 nuevo1;

    public Button yourButton1;
    public Button yourButton2;
    public Button yourButton3;

    public Button C_B;  //acceptar
    public Button aux2; // rechazar
    public Button aux3; // pasar turno

    private Vector3 auxiliar1;
    private Vector3 v1;

    private int tiempo = 99;
    private float startTime;
    private float journeyLength;


    private float lerpTime = 1;
    private float clerpTime = 0;
    bool moved = false;

    void Start()
    {
        Button btn1 = yourButton1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
        startTime = Time.time;
    }
    void Update()
    {
        GameObject canvas;
        canvas = GameObject.Find("Canvos");
        h = canvas.GetComponent<RectTransform>().rect.height;
        w = canvas.GetComponent<RectTransform>().rect.width;

        if(!moved)
            auxiliar1 = yourButton1.transform.position;

        float wcarta = 275;

        nuevo1 = new Vector3((float)(0.5 * w), (float)(0.6* h), 0);

        if (tiempo == 0)
        {
            tiempo = 2;
        }
        if (tiempo == 1)
        {
            tiempo = 3;
        }
        if (tiempo == 2)
        {        
            clerpTime += Time.deltaTime;
            if (clerpTime >= lerpTime)
            {
                clerpTime = lerpTime;
            }
            float perc = clerpTime / lerpTime;

            yourButton1.transform.position = Vector3.Lerp(auxiliar1, nuevo1, perc);
            
            if(yourButton1.transform.position== nuevo1)
            {
                aux2.onClick.AddListener(rechazar_opcion);
                C_B.onClick.AddListener(acceptar_opcion);
                tiempo = 55;
            }
            aux2.onClick.AddListener(rechazar_opcion);
            C_B.onClick.AddListener(acceptar_opcion);         
        }
        if (tiempo == 3)
        {
            clerpTime += Time.deltaTime;
            if (clerpTime >= lerpTime)
            {
                clerpTime = lerpTime;
            }
            float perc = clerpTime / lerpTime;

            yourButton1.transform.position = Vector3.Lerp(v1, auxiliar1, perc);          
        }


    }

    void TaskOnClick()
    {
        moved = true;
        Vector3 scal_petit = new Vector3(0.7f, 0.6f, 1f);
        C_B.gameObject.SetActive(true);
        aux2.gameObject.SetActive(true);

        yourButton3.interactable = false;
        yourButton2.interactable = false;
        yourButton1.transform.localScale = scal_petit;

        tiempo = 0;
        clerpTime = 0;
    }

    void rechazar_opcion()
    {
        Vector3 scal_petit = new Vector3(0.6f, 0.3f, 1f);
        C_B.gameObject.SetActive(false);
        aux2.gameObject.SetActive(false);
        clerpTime = 0;
        yourButton3.interactable = true;
        yourButton2.interactable = true;
        yourButton1.transform.localScale = scal_petit;
        v1 = yourButton1.transform.position;
        tiempo = 1;
    }
    void acceptar_opcion()
    {
        Vector3 scal_petit = new Vector3(0.6f, 0.3f, 1f);
        yourButton1.transform.position = auxiliar1;
        yourButton3.interactable = true;
        yourButton2.interactable = true;
        clerpTime = 0;
    }
}
