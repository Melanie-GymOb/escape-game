using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=a5WXiMN3APk
public class InteractiveDrawers : MonoBehaviour
{
    [SerializeField] private Vector3 openPosition;
    [SerializeField] private Vector3 closedPosition;

    
    [SerializeField] private float animationTime;

    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;

    private bool isClosed = true;

    private Hashtable iTweenArgs; //nötig, um Bezug zu lokalem Ort statt Weltort zu machen; Array, das irgendetwas als Index haben kann; hier Strings

    void Start()
    {
        iTweenArgs = iTween.Hash(); 
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
    }

    void OnMouseDown(){
        if(isClosed){
            iTweenArgs["position"] = openPosition;
            iTween.MoveTo(this.gameObject, iTweenArgs);  
            isClosed = false;  
        }
        else{
            iTweenArgs["position"] = closedPosition;
            iTween.MoveTo(this.gameObject, iTweenArgs);
            isClosed = true; 
        }     
    }

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
}
