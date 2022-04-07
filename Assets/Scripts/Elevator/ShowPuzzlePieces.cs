using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPuzzlePieces : MonoBehaviour
{
    [SerializeField] GameObject[] showPuzzle = new GameObject[9];
    
    
    public void ShowImages(){
        if(showPuzzle != null ){
            for(int i = 0; i < showPuzzle.Length; i++) {
                showPuzzle[i].SetActive(true);
            }
        }
    }
}
