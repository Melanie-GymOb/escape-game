using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    //StartSceneButton startScene; 
    
    /*void Awake(){ 
        startScene = FindObjectOfType<StartSceneButton>();
    }
    
    
    void Start()
    {
        startScene.gameObject.SetActive(true);
    }*/

    public void OnStartGame(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);        
    }
}
