using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory2 : MonoBehaviour
{
    public GameObject showImage;
    
    
    public void ShowImage2(){
        if(showImage != null ){
            showImage.SetActive(true);
        }
    }
}
