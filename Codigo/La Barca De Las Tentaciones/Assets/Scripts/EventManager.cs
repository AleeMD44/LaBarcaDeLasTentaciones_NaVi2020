using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    bool started = false;
    private Queue<string> sentences;

    public GameObject eventPanel;
    public GameObject healthbar;
    public GameObject foodbar;
    public TextMeshProUGUI displayText;

    string activeSentence;
    public float typingSpeed;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        if (started == false)
        {
            healthbar.SetActive(false);
            foodbar.SetActive(false);
            eventPanel.SetActive(true);

            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }
            started = true;
            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        activeSentence = sentences.Dequeue();
        displayText.text = activeSentence;

        StopAllCoroutines();
        StartCoroutine(TypeTheSentence(activeSentence));

    }

    IEnumerator TypeTheSentence(string sentence)
    {
        displayText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


    void EndDialogue()
    {
        eventPanel.SetActive(false);
        started = false;
        healthbar.SetActive(true);
        foodbar.SetActive(true);
    }
}
