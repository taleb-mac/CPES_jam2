using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public int levelToLoad;

    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FadeOut()
    {
        anim.SetTrigger("FadeOut");
    }
    
    public void loadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
