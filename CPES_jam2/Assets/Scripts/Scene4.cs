using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4 : MonoBehaviour
{
    public int state;

    public GameObject button1;
    public GameObject button2;

    public GameObject text;
    public GameObject nameText;
    public GameObject contButton;

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
        if(state == 6)
        {
            button1.SetActive(true);
            button2.SetActive(true);

            nameText.SetActive(false);
            text.SetActive(false);
            contButton.SetActive(false);

        }
    }

    public void fight()
    {
        SceneManager.LoadScene("Battle");
    }
}
