using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ReadingText : MonoBehaviour
{
    
    
    public void GoBack(){
        SceneManager.UnloadSceneAsync(7);
    }
}