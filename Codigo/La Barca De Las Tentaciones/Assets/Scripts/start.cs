using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    float h;
    float w;
    private Vector3 spawnPos1;
    private Vector3 spawnPos2;
    private Vector3 spawnPos3;
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
    
    private Vector3 scal_petit = new Vector3(0.6f, 0.3f, 1f);
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
    // Start is called before the first frame update
    void Start()
    {
        empezar.onClick.AddListener(empezar_game);
        

    }
    void empezar_game()
    {
        spawnPos1 = new Vector3((float)(0.9 * w), (float)(0.85 * h), 0);
        spawnPos2 = new Vector3((float)(0.9 * w), (float)(0.5 * h), 0);
        spawnPos3 = new Vector3((float)(0.9 * w), (float)(0.15 * h), 0);

        comida_buena.transform.position = spawnPos1;
        comida_buena.transform.localScale = scal_petit;
        ropa_buena.transform.position = spawnPos1;
        ropa_buena.transform.localScale = scal_petit;
        x_buena.transform.position = spawnPos1;
        x_buena.transform.localScale = scal_petit;

        comida_neutra.transform.position = spawnPos2;
        comida_neutra.transform.localScale = scal_petit;
        ropa_neutra.transform.position = spawnPos2;
        ropa_neutra.transform.localScale = scal_petit;
        x_neutra.transform.position = spawnPos2;
        x_neutra.transform.localScale = scal_petit;

        comida_mala.transform.position = spawnPos3;
        comida_mala.transform.localScale = scal_petit;
        ropa_mala.transform.position = spawnPos3;
        ropa_mala.transform.localScale = scal_petit;
        x_mala.transform.position = spawnPos3;
        x_mala.transform.localScale = scal_petit;
        int randomNumber = Random.Range(0, 3);
        if (randomNumber == 0)
        {      
            comida_buena.gameObject.SetActive(true);
            comida_neutra.gameObject.SetActive(true);
            comida_mala.gameObject.SetActive(true);
        }
        if (randomNumber == 1)
        {           
            ropa_buena.gameObject.SetActive(true);
            ropa_neutra.gameObject.SetActive(true);
            ropa_mala.gameObject.SetActive(true);
        }
        if (randomNumber == 2)
        {           
            x_buena.gameObject.SetActive(true);
            x_neutra.gameObject.SetActive(true);
            x_mala.gameObject.SetActive(true);
        }
        empezar.gameObject.SetActive(false);

    }

}
