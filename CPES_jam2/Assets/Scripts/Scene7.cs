using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scene7 : MonoBehaviour
{
    // Start is called before the first frame update
    public int state;

    public GameObject button1;
    public GameObject button2;

    public GameObject text;
    public GameObject nameText;
    public GameObject contButton;

    public GameObject remember;

    public bool comfort;
    public TextStuff textStuff;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextState();
        }
    }

    public void NextState()
    {
        state++;
        SceneStuffs();
    }

    void SceneStuffs()
    {
        if (state == 15)
        {
            button1.SetActive(true);
            button2.SetActive(true);

            nameText.SetActive(false);
            text.SetActive(false);
            contButton.SetActive(false);
        }
        else if (state ==16)
        {
            button1.SetActive(false);
            button2.SetActive(false);

            nameText.SetActive(true);
            text.SetActive(true);
            contButton.SetActive(true);

        }

    }

    public void Comfort()
    {
        state++;
        SceneStuffs();
        remember.SetActive(true);
        textStuff.sentences.Enqueue("Thanks for the tips, you realy are good at dealing with death huh..");
    }

    public void Ignore()
    {
        state++;
        SceneStuffs();
        remember.SetActive(true);
        textStuff.sentences.Enqueue("I guess I'll go cry my self to sleep");
    }
}
