using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CountCorrectPieceComputer : ScriptableObject
{
    [SerializeField] int number; 
    [SerializeField] int initialNumber; 
    
    
    public void ChangeNumber(){
        number += 1; 
    }

    public int GetNumber(){
        return number;
    }

    public void ResetValue(){
        number = initialNumber;
    }
}
