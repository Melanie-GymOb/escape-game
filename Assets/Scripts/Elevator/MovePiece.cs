using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    
    

    private Vector3 mOffset;

    private float mZCoord; 

    Rigidbody m_Rigidbody;

    public string pieceStatus = "";
    public Transform edgeParticles;
    public string pieceHoldByMouse = "";
    

    [SerializeField] Texture2D cursor; 
    [SerializeField] Texture2D cursorOver;
    [SerializeField] CorrectPieceShown CorrectPiece;
    [SerializeField] int thisNumber;
    [SerializeField] GameObject showPuzzle;
    
    
    private void Awake()
    {   
        
        ChangeCursor(cursor);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined; //Cursor verschwindet nicht vom Bildschirm 
    }

    // Start is called before the first frame update
    void Start()
    {
       m_Rigidbody = GetComponent<Rigidbody>(); 
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
    void OnMouseDown(){
        //Debug.Log("hallo");
       if (thisNumber == CorrectPiece.GetNumber()){
           showPuzzle.SetActive(true); //TO DO
           CorrectPiece.ChangeNumber();
           Destroy(gameObject); 
           Instantiate(edgeParticles, showPuzzle.transform.position, edgeParticles.rotation);
        //}
       }
    }
   

    

    

    /*private void OnMouseDown()
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
            m_Rigidbody.MovePosition(GetMouseWorldPos() + mOffset);
            pieceHoldByMouse = "yes";
        }
        

    }*/
      

    void OnMouseUp(){
        pieceHoldByMouse = "no";
    }
       
  //https://www.youtube.com/watch?app=desktop&v=4KeQpPGLW7I
 //www.youtube.com/watch?v=0yHBDZHLRbQ       

    

}
