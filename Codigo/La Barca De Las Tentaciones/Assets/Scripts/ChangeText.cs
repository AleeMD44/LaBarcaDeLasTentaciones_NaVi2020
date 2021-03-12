using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText: MonoBehaviour
{
    private DialogueTrigger dialogue;
    private DialogueTrigger dialogue2;
    private GameObject npc;
    private GameObject npc2;

    void Start()
    {
        npc = GameObject.Find("NPC");
        npc2 = GameObject.Find("NPC2");
    }

    void Update()
    {
        dialogue = npc.GetComponent<DialogueTrigger>();
        dialogue2 = npc2.GetComponent<DialogueTrigger>();
    }

    public void Destroy()
    {
        try
        {
            dialogue.DestroyComponent();
            dialogue2.DestroyComponent();
        }
        catch
        {

        }   
    }

}
