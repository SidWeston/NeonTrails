using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIdentity : MonoBehaviour
{
//\--------------------------------------------------------------------------------
//    SCRIPT: CharacterIdentity
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Renaming and assigning all new input controllers (GamePad) with a ne
//\--------------------------------------------------------------------------------
   void Awake()
	{
		gameObject.name = "Player " + CharacterNumber.characterNumber;
		CharacterNumber.characterNumber++;
		Debug.Log("Character Identity" + gameObject.name);
	}
}
