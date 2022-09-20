using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

//7https://www.youtube.com/watch?v=BGr-7GZJNXg
public class DragAndDrop : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDropHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;
    [SerializeField] CountCorrectPieceComputer CorrectPiece;
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
        canvasGroup.alpha = 1f; //etwas Transparenz
        canvasGroup.blocksRaycasts = true;
        }
    }

    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag.gameObject.name == gameObject.name){
            Debug.Log("done");
        }
    }

    public void ChangeCursor(Texture2D cursorType){
        Vector2 hotspot = new Vector2(cursorType.width/2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotspot, CursorMode.Auto);
    }

    public void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == gameObject.name){
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            CorrectPiece.ChangeNumber();
            ChangeCursor(cursor);
            Debug.Log("done");
        }

        if (CorrectPiece.GetNumber() == totalnumber){
            SceneManager.LoadScene("ThirdPuzzleScene");
        }
    }
}
