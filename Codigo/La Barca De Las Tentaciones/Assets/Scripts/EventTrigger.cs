using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public GameManager gm;
    public int comida;
    public int vida;

    public void TriggerDialogue()
    {
        
        FindObjectOfType<EventManager>().StartDialogue(dialogue);
    }

    void OnMouseDown()
    {
        TriggerDialogue();
        return;
    }

    public void DestroyComponent()
    {
        Destroy(this);
        gm.Event(comida, vida);
    }

}
