using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartLevel : MonoBehaviour
{
     public void LevelStart()
     {
        SceneManager.LoadScene(1);    
     }
}
