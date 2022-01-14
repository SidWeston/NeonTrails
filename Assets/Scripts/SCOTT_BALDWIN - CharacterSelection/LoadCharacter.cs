using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//\--------------------------------------------------------------------------------
//    SCRIPT: LoadCharacter
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Scripting for transfering players cars to the designated spawn points Version2
//\--------------------------------------------------------------------------------
public class LoadCharacter : MonoBehaviour {
    
    // The array for all prefab options
    [SerializeField] private GameObject[] characterPrefabs;
    // Spawn locations
    [SerializeField] private Transform spawnLocation1;
    [SerializeField] private Transform spawnLocation2;
    
    public TMP_Text playerNumber;
    private bool playerOne = false;
    private bool playerTwo = false;
    
    private void Awake() {
        
        // Debug.Log(gameObject.name + playerOne + playerTwo);
    }
    
    void Update() {
        // Created new variable selected character that is assigned the player prefs selected character 
        
    
             if (gameObject.name == "Player 0") {
                JoinPlayerOne();
             }              
    
             // if (gameObject.name == "Player 1") {
             //     GameObject prefab = characterPrefabs[selectedCharacter];
             //     GameObject clone = Instantiate(prefab, spawnLocation2.position, Quaternion.identity);
             // }
    
    }

    void JoinPlayerOne() {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        Debug.Log("This is player One");
                     GameObject prefab = characterPrefabs[selectedCharacter]; 
                        Debug.Log("Player one chose" + prefab);
                    GameObject clone = Instantiate(prefab, spawnLocation1.position, Quaternion.identity);
                        Debug.Log("Player one's car has been instantiated");
    }
}
