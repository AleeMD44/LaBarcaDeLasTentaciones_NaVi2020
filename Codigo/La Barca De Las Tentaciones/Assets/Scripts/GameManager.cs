using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Player player;
    private Card cartaFinal;

    void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    public void cartaEscogida (Card c)
    {
        cartaFinal = c;
    }

    public void endTurn()
    {
        player.comida += cartaFinal.comidaMod;
        if (player.comida <= 0)
        {
            player.comida = 0;
        }
        player.vida += cartaFinal.vidaMod;
        player.karma += cartaFinal.karmaMod;
    }

    public void Event (int comida, int vida){
        player.vida += vida;
        player.comida += comida;
    }

    public void iaTurn()
    {
        player.comida += cartaFinal.comidaMod;
        if (player.comida <= 0)
        {
            player.comida = 0;
        }
        player.vida += cartaFinal.vidaMod;
    }

    public void endTurn1()
    {
        player.comida--;
        if (player.comida <= 0)
        {
            player.comida = 0;
            player.vida -= 3;
        }
        
        if (player.vida > 120)
        {
            player.vida = 120;
        }else if(player.vida <= 0)
        {
            Application.Quit();
        }
       
        if (player.karma > 100)
        {
            player.karma = 100;
        }
        else if (player.karma < 0)
        {
            player.karma = 0;
        }
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
