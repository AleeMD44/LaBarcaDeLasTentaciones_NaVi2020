using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverCarta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject borde;
    bool bordeable = false;
    public void Start()
    {
        borde.SetActive(false);
    }

    public void Update()
    {
        if (bordeable)
        {
            borde.SetActive(true);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        borde.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        borde.SetActive(false);
    }

    public void OnceClicked()
    {
        bordeable = true;
    }

    public void OnceRejected()
    {
        bordeable = false;
        borde.SetActive(false);
    }
}
