using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NewTry : MonoBehaviour
{
    public void RestartCoding(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        //SceneManager.UnloadSceneAsync(18);
    }
}
