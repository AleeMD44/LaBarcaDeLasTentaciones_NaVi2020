using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AcabarTurno;

    // Update is called once per frame

    public void Trigger()
    {
        try
        {
            AcabarTurno.GetComponent<EventTrigger>().TriggerDialogue();
            return;
        }
        catch { }
        
    }
}
