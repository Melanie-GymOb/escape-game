using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScratch : MonoBehaviour
{
    public void OnScratchPressed(){
        SceneManager.LoadScene("ProgrammingDef");
    }
}
