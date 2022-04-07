using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllSwitches : MonoBehaviour
{
    private bool setToZero = true;
    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;
    
    public void ChangeCursor(Texture2D cursorType){
        Vector2 hotspot = new Vector2(cursorType.width/2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotspot, CursorMode.Auto);
    }

    void OnMouseEnter(){
        ChangeCursor(cursorOver);
    }

    void OnMouseExit(){
        ChangeCursor(cursor);
    }

    private void OnMouseDown(){
        if (setToZero){
            transform.localEulerAngles = new Vector3(0,0,135);
            setToZero = false;
        }
        else {
            transform.localEulerAngles = new Vector3(0,0,45);
            setToZero = true;
        }
    }
    public bool GetStatus(){
        return setToZero;
    }

}
