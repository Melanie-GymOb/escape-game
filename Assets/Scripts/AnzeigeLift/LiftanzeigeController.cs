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
    [SerializeField] GameObject codeIsCorrect;
    [SerializeField] GameObject codeIsFalse;
    int[] enteredNumbers = new int[3];
    int counterAnswers = 0;

      

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
               codeIsCorrect.SetActive(true);
               int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
               int nextSceneIndex = currentSceneIndex + 2;
                SceneManager.LoadScene(nextSceneIndex); 
           }

        else {
               codeIsFalse.SetActive(true);
               counterAnswers = 0;
               countField = 0;
               foreach(var obj in displayTexts) {
                obj.color = Color.red;
               }
        }
        Debug.Log("Check");
    }

    public void Restart(){
        Debug.Log("Restart");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(5);
    }

    public void GoBackTo1(){
       //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
       //int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.UnloadSceneAsync(5);
        
    }
    
    
    


}
