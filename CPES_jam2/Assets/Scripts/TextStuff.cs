using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStuff : MonoBehaviour
{

    Queue<string> sentences;
    public Dialogue dialogue;

    public Text textBox;
    public Text nameBox;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        StartCoroutine(StartDialogue(dialogue));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public IEnumerator StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        StartCoroutine(TypeScentence(dialogue.name, nameBox));
        yield return new WaitForSeconds(0.5f);

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        StartCoroutine(TypeScentence(sentences.Dequeue(), textBox));
    }

    IEnumerator TypeScentence(string sentence, Text textBox)
    {
        textBox.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        print("aaaaaaaa");
    }





}
