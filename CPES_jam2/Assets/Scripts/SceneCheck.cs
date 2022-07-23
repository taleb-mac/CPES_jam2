using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int state;

    public GameObject button1;
    public GameObject button2;

    public GameObject text;
    public GameObject nameText;
    public GameObject contButton;

    public Text textName;
    public Text textButton;

    public int scene;


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
        if (state == 1)
        {
            textName.text = "Mom";
        }
        else if (state == 2)
        {
            button1.SetActive(true);
            button2.SetActive(true);

            nameText.SetActive(false);
            text.SetActive(false);
            contButton.SetActive(false);

        }

    }

    public void Comfort()
    {
        SceneManager.LoadScene(scene);
    }

    public void Ignore()
    {
        SceneManager.LoadScene(7);
    }
}
