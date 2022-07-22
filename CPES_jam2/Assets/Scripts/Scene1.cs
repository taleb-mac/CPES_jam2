using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour
{
    public int state;

    public GameObject image;

    public GameObject Smoke;
    public GameObject baba;

    public AudioSource source;
    public AudioClip doorKnock;

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
            SceneStuffs();
        }
        
    }

    public void NextState()
    {
        state++;
        SceneStuffs();
    }

    void SceneStuffs()
    {
        switch(state)
        {
            case 0:
                break;
            case 1:
                // add screen shake + knock sound
                source.PlayOneShot(doorKnock);
                StartCoroutine(ScreenShake());
                break;
            case 2:
                // instantiate principle
                StartCoroutine(BabaAppear());
                break;

        }
    }

    IEnumerator ScreenShake()
    {
        for(int i=0; i<200;  i++)
        {
            image.transform.eulerAngles += new Vector3(0, 0, Random.Range(-0.6f, 0.6f));
            yield return null;
            image.transform.eulerAngles -= new Vector3(0, 0, Random.Range(-0.6f, 0.6f));
        }
        image.transform.eulerAngles = Vector3.zero;

    }

    IEnumerator BabaAppear()
    {
        Instantiate(Smoke, transform);
        yield return new WaitForSeconds(1f);
        baba.SetActive(true);
    }
}
