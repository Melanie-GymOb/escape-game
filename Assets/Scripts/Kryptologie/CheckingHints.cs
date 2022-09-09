using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CheckingHints : MonoBehaviour
{
    [SerializeField] GameObject displayHint;


    

    public void OnHelpButtonSelected(){
       displayHint.SetActive(true);
        
       
    }

    public void OnReturnButtonSeleced(){
        SceneManager.UnloadSceneAsync("HinweiseKryptologie");
    }
}
