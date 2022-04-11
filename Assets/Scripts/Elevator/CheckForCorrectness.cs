using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForCorrectness : MonoBehaviour
{
    [SerializeField] ControllSwitches[] allSwitches= new ControllSwitches[5];
    
    void OnMouseDown(){ 
        if (CheckStatus() == false){
            gameObject.GetComponent<ShowInventory>().ShowImage();  
            }
        if (CheckStatus() == true){
            //Debug.Log("Rätsel gelöst"); 
            /*int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;*/
            SceneManager.LoadScene("ThirdPuzzleScene");
            }
    }

    private bool CheckStatus(){
        if(allSwitches[0].GetStatus() == false && 
        allSwitches[1].GetStatus() == false &&
        allSwitches[2].GetStatus() == true &&
        allSwitches[3].GetStatus() == true &&
        allSwitches[4].GetStatus() == false ){
            return true;
        }
        if(allSwitches[0].GetStatus() == false && 
        allSwitches[1].GetStatus() == false &&
        allSwitches[2].GetStatus() == true &&
        allSwitches[3].GetStatus() == false &&
        allSwitches[4].GetStatus() == true){
            return true;
        }
        else{
            return false;
        }
    }
}
