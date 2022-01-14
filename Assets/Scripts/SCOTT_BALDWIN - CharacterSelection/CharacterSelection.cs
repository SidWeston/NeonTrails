using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
//\--------------------------------------------------------------------------------
//    SCRIPT: CharacterSelection
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Character selection UI and Input controls for players car selection
//\--------------------------------------------------------------------------------
public class CharacterSelection : MonoBehaviour
{
    [SerializeField] GameObject[] carSelection;

    [SerializeField] private Transform spawnLocation1;
    [SerializeField] private Transform spawnLocation2;

    public static GameObject selectedCar;
    
    
    // Setting a varaible to keep track of players selected car in the array
    public int selectedCharacter = -1;
    
    private void Awake() {
        // Debugging - Identify the current Gamepad / player number
        Debug.Log(gameObject.name);
    }
    
    // Setting the correct car prefab to be active and for looping around the available cars in the array
    public void NextCharacter() {
        carSelection[selectedCharacter].SetActive(false);
        Debug.Log(carSelection[selectedCharacter]);
        selectedCharacter = (selectedCharacter + 1) % carSelection.Length;
        carSelection[selectedCharacter].SetActive(true);
        selectedCar = carSelection[selectedCharacter];
    }
  
    public void PreviouCharacter() {
        carSelection[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0) {
            selectedCharacter += carSelection.Length;
        }
        carSelection[selectedCharacter].SetActive(true);
        selectedCar = carSelection[selectedCharacter];
    }
    
    // Setting the players choice of car to their "PlayersPrefs"
    public void CharacterSelected() {
    
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        
        SceneManager.LoadScene(3);
    }
}
