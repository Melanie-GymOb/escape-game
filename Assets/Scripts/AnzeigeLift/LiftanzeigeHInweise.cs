using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftanzeigeHInweise : MonoBehaviour
{
    [SerializeField] GameObject[] displayHints;
    int acutalindex = 0;
    LiftanzeigeController controller = new LiftanzeigeController();

    

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
