using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(goToMain());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator goToMain()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(0);
    }
}
