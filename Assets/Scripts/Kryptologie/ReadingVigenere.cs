using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadingVigenere : MonoBehaviour
{  
    
    public void GoBack(){
        SceneManager.UnloadSceneAsync(13);
    }
}
