using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PressHelpButton : MonoBehaviour
{
    [SerializeField] int nextSceneIndex;
    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;   

    private void Awake()
    {   
        
        ChangeCursor(cursor);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined; //Cursor verschwindet nicht vom Bildschirm 
    }
        
        

    public void ChangeCursor(Texture2D cursorType){
        Vector2 hotspot = new Vector2(cursorType.width/2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotspot, CursorMode.Auto);
    }


    void OnMouseDown(){ 
      SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Additive);
    }

    void OnMouseEnter(){
        ChangeCursor(cursorOver);
    }

    void OnMouseExit(){
        ChangeCursor(cursor);
    }
}
