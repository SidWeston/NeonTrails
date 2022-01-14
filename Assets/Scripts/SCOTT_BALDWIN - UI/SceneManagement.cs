using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
   //\--------------------------------------------------------------------------------
   //    SCRIPT: SceneManagement
   //    Author: Scott Baldwin
   //    Last Modified: 25/05/21
   //    Brief: Controlling the flow of UI buttons to their corresponding scenes
   //\--------------------------------------------------------------------------------
   public void PlayButton() {
      Debug.Log("PLAY GAME - BUTTON PRESSED");
      SceneManager.LoadScene("02.CharacterSelection  - SCOTT BALDWIN");
   }
   public void OptionsButton() {
      Debug.Log("OPTIONS - BUTTON PRESSED");
      SceneManager.LoadScene("03.Instructions  - SCOTT BALDWIN");
   }

   public void BackButton() {
      SceneManager.LoadScene("01.MAIN MENU  - SCOTT BALDWIN");
   }

   public void QuitGame() {
      Application.Quit();
   }
}
