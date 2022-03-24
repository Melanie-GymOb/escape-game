using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownScript : MonoBehaviour
{
    void OnMouseOver()
    {
        Debug.Log("Mouse");
    }
    void OnMouseExit()
    {
        
        Debug.Log("Mouse is no longer on GameObject.");
    }
}
