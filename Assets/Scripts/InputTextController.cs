using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputTextController : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI[] correctCodingLine;
   [SerializeField] TMP_InputField[] userInputField;
   
   public void checkInput(){
        for(int i = 0; i < correctCodingLine.Length; i++) {
            if (correctCodingLine[i].text == userInputField[i].text){
                Debug.Log("correct");
            };
        }
        
   }
}
