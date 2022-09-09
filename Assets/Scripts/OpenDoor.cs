using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool closed = true;
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
        if (closed){
            transform.localEulerAngles = new Vector3(0,-90,0);
            transform.position = transform.position + new Vector3(2,0,-1);
            closed = false;
        }
        //else {
           // transform.localEulerAngles = new Vector3(0,0,0);
           //transform.position = transform.position + new Vector3(0,0,0);
           //closed = true;
        //}
    }
    public bool GetStatus(){
        return closed;
    }

}
