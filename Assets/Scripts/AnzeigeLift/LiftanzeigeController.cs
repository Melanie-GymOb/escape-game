using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class LiftanzeigeController : MonoBehaviour
{
    [Header("Eingabeziffern")]
    [SerializeField] GameObject[] inputButtons;
    //int correctAnswerIndex;

    [Header("Anzeigefeld")]
    [SerializeField] LiftanzeigeFelder[] outputField;
    [SerializeField] TextMeshProUGUI[] displayTexts;
    int countField = 0;
    int currentCorrectNumber;
    
    [SerializeField] TextMeshProUGUI numberNotCorrectText;
    int[] enteredNumbers = new int[3];
    int counterAnswers = 0;

    /**void Awake(){
        currentCorrectNumber = outputField[countField].GetCorrectAnswerDigit();
        //Debug.Log(currentCorrectNumber);
        //Debug.Log(displayTexts.Length);
    }**/

    

    public void OnAnswerSelected(int index)
    {
        currentCorrectNumber = outputField[countField].GetCorrectAnswerDigit();
        DisplayAnswer(index); 
        if (countField < outputField.Length){
            countField = countField + 1;
            counterAnswers = counterAnswers + 1; 
            //Debug.Log(currentCorrectNumber);
        }
        if (counterAnswers == 3){
            Debug.Log("Hallo");
            CheckCorrectness();
        }
        
    }

    void DisplayAnswer(int index){
        displayTexts[countField].text = index.ToString(); //Anzeigetexte werden durch gedrückte Ziffer ersetzt
        
        if(currentCorrectNumber == index){
            //Debug.Log("Hallo");
            TextMeshProUGUI actual = displayTexts[countField];
            actual.color = Color.black;
            numberNotCorrectText.text = ("Diese " + (countField + 1) + ". Ziffer ist korrekt.");
            
            }
        else{
            numberNotCorrectText.text = ("Diese " + (countField + 1) + ". Ziffer ist falsch.");
        }
        enteredNumbers[countField] = index;
        Debug.Log(enteredNumbers[countField]);
        
        }
    
    void CheckCorrectness(){
        
        if(enteredNumbers[0] == outputField[0].GetCorrectAnswerDigit() &&
           enteredNumbers[1] == outputField[1].GetCorrectAnswerDigit() && 
           enteredNumbers[2] == outputField[2].GetCorrectAnswerDigit()){
               int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
               int nextSceneIndex = currentSceneIndex + 1;
                SceneManager.LoadScene(nextSceneIndex); 
           }
        Debug.Log("Check");
    }

    public void Restart(){
        Debug.Log("Restart");
        SceneManager.LoadScene(2);
    }

    public void GoBackTo1(){
        SceneManager.LoadScene(1);
    }
    
    
    


}
