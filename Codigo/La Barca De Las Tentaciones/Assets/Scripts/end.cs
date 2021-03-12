using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public Text IA;
    float h;
    float w;
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

    public int caso;
    private int num = 0;
    private Vector3 spawnPos1;
    private Vector3 spawnPos2;
    private Vector3 spawnPos3;
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
    private Vector3 scal_petit = new Vector3(0.6f, 0.3f, 1f);
    // Start is called before the first frame update
    void Start()
    {
        acc.onClick.AddListener(empezar_game);
    }
    
    void empezar_game()
    {
        IA.gameObject.SetActive(false);
        comida_buena.transform.position = spawnPos1;
        comida_neutra.transform.position = spawnPos2;
        comida_mala.transform.position = spawnPos3;
        ropa_buena.transform.position = spawnPos1;
        ropa_neutra.transform.position = spawnPos2;
        ropa_mala.transform.position = spawnPos3;
        x_buena.transform.position = spawnPos1;
        x_neutra.transform.position = spawnPos2;
        x_mala.transform.position = spawnPos3;
        
        acc.gameObject.SetActive(false);
        den.gameObject.SetActive(false);

        empezar.gameObject.SetActive(true);
        actual.transform.localScale = scal_petit;

        comida_buena.gameObject.SetActive(false);
        comida_neutra.gameObject.SetActive(false);
        comida_mala.gameObject.SetActive(false);

        ropa_buena.gameObject.SetActive(false);
        ropa_neutra.gameObject.SetActive(false);
        ropa_mala.gameObject.SetActive(false);

        x_buena.gameObject.SetActive(false);
        x_neutra.gameObject.SetActive(false);
        x_mala.gameObject.SetActive(false);
    }
}
