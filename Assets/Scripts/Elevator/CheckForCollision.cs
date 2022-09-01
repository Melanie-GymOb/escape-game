using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCollision : MonoBehaviour
{
    
    
    public string pieceStatus = "";
    public Transform edgeParticles;
    public string pieceHoldByMouse = "";

    

    [SerializeField] MovePiece puzzlePiece;

    
     

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.name == gameObject.name) && (puzzlePiece.pieceHoldByMouse == "no")){
            other.GetComponent<BoxCollider>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.transform.position = transform.position;
            
            Instantiate(edgeParticles, gameObject.transform.position, edgeParticles.rotation);
            puzzlePiece.pieceStatus = "locked";
        }
        
           }
}
