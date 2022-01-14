using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//\--------------------------------------------------------------------------------
//    SCRIPT: CharatcerSelection
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Offsetting the position of player 2's position
//\--------------------------------------------------------------------------------
public class CharacterSelectionPos : MonoBehaviour
{

[SerializeField] GameObject[] playerSign;
    public void Start() 
    {
        if(gameObject.name == ("Player 0"))
        {
            transform.position = transform.position += new Vector3 (0,0,0);
            playerSign[1].SetActive(false);
            
        }
        else if (gameObject.name == ("Player 1"))
        {
            transform.position = transform.position += new Vector3 (200,0,0);
            playerSign[0].SetActive(false);
        }
        
    }

}