using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class DisplayHintsElevator : MonoBehaviour
{
    [SerializeField] GameObject[] displayHints;
    int acutalindex = 0;
    LiftanzeigeController controller = new LiftanzeigeController();
    ControlSpheres c = new ControlSpheres();

    

    public void OnHelpButtonSelected(){
       if(acutalindex < displayHints.Length){
            displayHints[acutalindex].SetActive(true);
            acutalindex = acutalindex + 1;
       }
       
    }

    public void OnNewTryButtonSelected(){
        controller.Restart();
    }

    public void OnReturnButtonSeleced(){
        controller.GoBackTo1();
    }
}
