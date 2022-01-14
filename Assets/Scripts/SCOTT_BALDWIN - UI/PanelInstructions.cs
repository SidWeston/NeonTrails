using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
//\--------------------------------------------------------------------------------
//    SCRIPT: PanelInstructions
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Simple script to turn the Character selections UI's on and off
//\--------------------------------------------------------------------------------
public class PanelInstructions : MonoBehaviour {
  
   [SerializeField] private GameObject enterTheGame = null;
   [SerializeField] private GameObject confirm = null;
   
   private void Start() {
      // Setting the confirm panel to start turned off
      confirm.gameObject.SetActive(false);
   }

   private void Update() {
      // Checking if a player has been added to the scene 
      GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
      if (player.Length > 0)
      {
         // Turning off the enter the game and turning on the confirmation UI overlay
         enterTheGame.gameObject.SetActive(false);
         confirm.gameObject.SetActive(true);
      }
   }
}
