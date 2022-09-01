using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private List<CorrectPieceShown> allResources;
    // Start is called before the first frame update
    
    
    private void Awake()
    {
        foreach (var resource in allResources){
            resource.ResetValue();
        }
    }
}
