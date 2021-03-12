using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    private int turno = 1;
    public Player player;
    public GameObject pinguino;
    void Update()
    {
        if(turno > 10 || player.vida <= 0)
        {
            Application.Quit();
        }
        
    }

    public void changeTurno()
    {
        turno++;
        if (turno == 5)
        {
            pinguino.SetActive(true);
        }
        if (turno == 6)
        {
            pinguino.SetActive(false);
        }
    }
}
