using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStuff : MonoBehaviour
{

    public Queue<string> sentences;
    public Dialogue dialogue;

    public Text textBox;
    public Text nameBox;


    public AudioSource source;
    public AudioClip bleep;

    public Fade fade;


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
        yield return new WaitForSeconds(0.5f);
        sentences.Clear();
        nameBox.text = dialogue.name;
        yield return new WaitForSeconds(0.5f);

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        StopAllCoroutines();
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        StartCoroutine(TypeSentence(sentences.Dequeue(), textBox));
    }

    IEnumerator TypeSentence(string sentence, Text textBox)
    {
        textBox.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(0.05f);

            if (letter != ' ')
            {
                source.pitch = 1 + Random.Range(-0.3f, 0.3f);
                source.PlayOneShot(bleep, 0.5f);
            }
        }
    }

    void EndDialogue()
    {
        fade.FadeOut();
    }

}
