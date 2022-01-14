using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//\--------------------------------------------------------------------------------
//    SCRIPT: PlayerIDObject
//    Author: Scott Baldwin
//    Last Modified: 26/05/21
//    Brief: Setting the character selection P1 and P2 icons per player
//\--------------------------------------------------------------------------------
public class PlayerIDObject : MonoBehaviour {

    [SerializeField] private GameObject p1 = null;
    [SerializeField] private GameObject p2 = null;
    private void Awake() {

        if(gameObject.name == ("Player 0"))
        {
            // gameObject.transform.GetChild(1).gameObject.SetActive(false);
            p2.gameObject.SetActive(false);
        }
        else if (gameObject.name == ("Player 1"))
        {
            // gameObject.transform.GetChild(0).gameObject.SetActive(false);
            p1.gameObject.SetActive(false); 
        }
    }
     
}
