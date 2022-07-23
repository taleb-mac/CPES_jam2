using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextScene());
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
