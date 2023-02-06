using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CodingController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    
    
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;

    [SerializeField] CountCorrectPieceComputer CorrectCodingLine;
    [SerializeField] int totalnumber;
    

    public string pieceStatus = "";
   
    private void Awake(){
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        ChangeCursor(cursor);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (pieceStatus != "locked"){
        ChangeCursor(cursorOver);
        }
    }

    
    public void OnPointerExit(PointerEventData eventData)
    {
        ChangeCursor(cursor);
    }

    public void OnBeginDrag(PointerEventData eventData){
        if (pieceStatus != "locked"){
        canvasGroup.alpha = 0.6f; //etwas Transparenz
        canvasGroup.blocksRaycasts = false; //
        }
    }

    public void OnDrag(PointerEventData eventData){
        if (pieceStatus != "locked"){
        ChangeCursor(cursorOver);
        rectTransform.anchoredPosition += eventData.delta; //um der Maus zu folgen;
        }
    }

    public void OnEndDrag(PointerEventData eventData){
       if (pieceStatus != "locked"){
        canvasGroup.alpha = 1f; 
        canvasGroup.blocksRaycasts = true;
        }
    }

    
    public void ChangeCursor(Texture2D cursorType){
        Vector2 hotspot = new Vector2(cursorType.width/2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotspot, CursorMode.Auto);
    }

    public void OnTriggerEnter2D(Collider2D other){
        
        if (other.gameObject.name == gameObject.name){
            pieceStatus = "locked"; 
            transform.position = other.gameObject.transform.position;
            CorrectCodingLine.ChangeNumber();
            ChangeCursor(cursor);
            
        }
    }

    public void OnButtonPressed(){
        if (CorrectCodingLine.GetNumber() == totalnumber){
            Debug.Log("todo");
            gameObject.GetComponent<ShowInventory>().ShowImage();
            gameObject.GetComponent<DontShowInventory>().DontShowImage();
            
        }
        else {
            gameObject.GetComponent<ShowInventory2>().ShowImage2();
        }
    }

    
}
