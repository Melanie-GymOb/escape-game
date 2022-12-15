using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BackToQuiz : MonoBehaviour
{
    public void GoBackToScene(){
       //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(14);
    }
}
