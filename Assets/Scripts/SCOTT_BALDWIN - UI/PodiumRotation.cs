using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodiumRotation : MonoBehaviour {
//\--------------------------------------------------------------------------------
//    SCRIPT: PodiumRotation
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Simple script to rotate the podium at the specified speeds and position
//\--------------------------------------------------------------------------------
    [SerializeField] GameObject Player1 = null;
    public float speed;

    
    void Update() {
        Player1.transform.Rotate(0, 1, 0 * speed, Space.Self ) ;
    
    }
    
    
}
