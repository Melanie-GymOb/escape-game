using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 


public class LiftanzeigeFelder : MonoBehaviour

{
    [SerializeField] int correctAnswerDigit; //Index der korrekten Antwort kann gespeichert werden
    //[SerializeField] TextMeshProUGUI outputDigit;

    public int GetCorrectAnswerDigit(){
        return correctAnswerDigit;
    }

    

    
}
