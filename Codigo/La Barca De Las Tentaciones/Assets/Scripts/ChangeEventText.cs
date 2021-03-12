using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeEventText: MonoBehaviour
{
    private EventTrigger dialogue;
    public GameObject AcabarTurno;

    void Update()
    {
        dialogue = AcabarTurno.GetComponent<EventTrigger>();
    }

    public void Destroy()
    {
        try
        {
            dialogue.DestroyComponent();
        }
        catch
        {

        }
    }
}
