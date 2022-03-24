using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpheres : MonoBehaviour
{
int a = 0;

void Awake() //wird immer gerufen, wenn diese Klasse gestartet wird (Start & Restart Szene)
    //wird genutzt, um einen Singelton zu erstellen
    {
        if (a == 0){
            DontDestroyOnLoad(gameObject); 
            a = a + 1; 
        }
        else {
            Destroy(gameObject);
        }
    }
}
