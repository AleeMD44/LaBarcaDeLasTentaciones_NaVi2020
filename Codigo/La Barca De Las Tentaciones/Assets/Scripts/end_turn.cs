using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class end_turn : MonoBehaviour
{
    private float startTime;
    private float journeyLength;


    private float lerpTime = 1;
    private float clerpTime = 0;

    public Button empezar;
    public Button comida_buena;
    public Button comida_neutra;
    public Button comida_mala;
    public Button ropa_buena;
    public Button ropa_neutra;
    public Button ropa_mala;
    public Button x_buena;
    public Button x_neutra;
    public Button x_mala;
    private float h;
    private float w;
    private Vector3 spawnPos1;
    private Vector3 spawnPos2;
    private Vector3 spawnPos3;
    // Start is called before the first frame update
    void Start()
    {
        empezar.onClick.AddListener(empezar_game_otra);
    }
    void Update()
    {
        GameObject canvas;
        canvas = GameObject.Find("Canvos");
        h = canvas.GetComponent<RectTransform>().rect.height;
        w = canvas.GetComponent<RectTransform>().rect.width;

        spawnPos1 = new Vector3((float)(0.9 * w), (float)(0.85 * h), 0);
        spawnPos2 = new Vector3((float)(0.9 * w), (float)(0.5 * h), 0);
        spawnPos3 = new Vector3((float)(0.9 * w), (float)(0.15 * h), 0);
    }

    // Update is called once per frame
    void empezar_game_otra()
    {
        int randomNumber = Random.Range(0, 3);

        if (randomNumber == 0)
        {
            comida_buena.gameObject.SetActive(true);
            comida_neutra.gameObject.SetActive(true);
            comida_mala.gameObject.SetActive(true);
            
            comida_buena.transform.position = spawnPos1;
            comida_neutra.transform.position = spawnPos2;
            comida_mala.transform.position = spawnPos3;

        }
        if (randomNumber == 1)
        {
            ropa_buena.gameObject.SetActive(true);
            ropa_neutra.gameObject.SetActive(true);
            ropa_mala.gameObject.SetActive(true);
     
            ropa_buena.transform.position = spawnPos1;
            ropa_neutra.transform.position = spawnPos2;
            ropa_mala.transform.position = spawnPos3;

        }
        if (randomNumber == 2)
        {
            x_buena.gameObject.SetActive(true);
            x_neutra.gameObject.SetActive(true);
            x_mala.gameObject.SetActive(true);
    
            x_buena.transform.position = spawnPos1;
            x_neutra.transform.position = spawnPos2;
            x_mala.transform.position = spawnPos3;
        }
     
        empezar.gameObject.SetActive(false);
    }
}
