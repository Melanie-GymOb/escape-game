using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{
    public GameObject showImage;
    
    
    public void ShowImage(){
        if(showImage != null ){
            showImage.SetActive(true);
        }
    }
}
