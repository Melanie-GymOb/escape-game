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

    /*void OnMouseDrag(){
        if (pieceStatus != "locked"){
            transform.position = GetMouseWorldPos() + mOffset;
            pieceHoldByMouse = "yes";
        }
        

    }*/
    void OnMouseDrag(){
        if (pieceStatus != "locked"){
            m_Rigidbody.MovePosition(GetMouseWorldPos() + mOffset);
            pieceHoldByMouse = "yes";
        }
        

    }

    void OnMouseUp(){
        pieceHoldByMouse = "no";
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.name == gameObject.name) && (pieceHoldByMouse == "no")){
            other.GetComponent<BoxCollider>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            transform.position = other.gameObject.transform.position;
            
            Instantiate(edgeParticles, other.gameObject.transform.position, edgeParticles.rotation);
            pieceStatus = "locked";
        }
        if (other.gameObject.tag == "Wall"){
            Debug.Log("Wall");
        }
    }

    /*private void OnCollisionEnter(Collision other)
        {
        if (other.gameObject.tag == "Wall"){
            Debug.Log("Wall");
        }
    }*/
       
  //https://www.youtube.com/watch?app=desktop&v=4KeQpPGLW7I
 //www.youtube.com/watch?v=0yHBDZHLRbQ       

    

}
