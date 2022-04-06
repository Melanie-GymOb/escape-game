using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   /* void Update()
    {
       Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z); //neuer Vektor übernimmt Mausposition
       Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);//ändert Mausposition in eine Unit
       transform.position = objPosition; //Objekt folgt Maus
    }*/

    //https://www.youtube.com/watch?app=desktop&v=4KeQpPGLW7I

    private Vector3 mOffset;

    private float mZCoord; 

    public string pieceStatus = "";
    //public Transform edgeParticles;

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

    void OnMouseEnter(){
        ChangeCursor(cursorOver);
    }

    void OnMouseExit(){
        ChangeCursor(cursor);
    }

//www.youtube.com/watch?v=0yHBDZHLRbQ
    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; //z-Koordinate der Maus

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    
    }

    private Vector3 GetMouseWorldPos(){
        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePosition);//ändert Mausposition in eine Unit der Welt
    }

    void OnMouseDrag(){
        if (pieceStatus != "locked"){
            transform.position = GetMouseWorldPos() + mOffset;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == gameObject.name){
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            //Instantiate(edgeParticles, other.gameObject.transform.position, edgeParticles.rotation);
        }
    }

    
        
        

    

}
