using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioStuff : MonoBehaviour
{
    public AudioSource source;
    public AudioClip battleStart;
    public AudioClip battle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(playBattleMusic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator playBattleMusic()
    {
        source.PlayOneShot(battleStart);
        yield return new WaitForSeconds(battleStart.length);
        source.Stop();
        source.loop = true;
        source.clip = battle;
        source.Play();

    }
}
