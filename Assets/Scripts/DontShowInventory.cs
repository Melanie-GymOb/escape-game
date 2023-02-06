using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontShowInventory : MonoBehaviour
{
    public GameObject showImage;
    
    
    public void DontShowImage(){
        if(showImage != null){
            showImage.SetActive(false);
        }
    }
}
