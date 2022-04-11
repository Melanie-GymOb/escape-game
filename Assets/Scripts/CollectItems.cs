using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;
    
    void OnMouseDown(){ 
            gameObject.GetComponent<ShowInventory>().ShowImage();      
            Destroy(gameObject);
            ChangeCursor(cursor);
    }

    void OnMouseEnter(){
        ChangeCursor(cursorOver);
    }

    void OnMouseExit(){
        ChangeCursor(cursor);
    }
    
    public void ChangeCursor(Texture2D cursorType){
        Vector2 hotspot = new Vector2(cursorType.width/2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotspot, CursorMode.Auto);
    }
}
