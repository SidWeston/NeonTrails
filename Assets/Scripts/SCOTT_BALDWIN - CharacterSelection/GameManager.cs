using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//\--------------------------------------------------------------------------------
//    SCRIPT: GameManager
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Scripting for transfering players cars to the designated spawn points
//\--------------------------------------------------------------------------------

public class GameManager : MonoBehaviour {
    // Array for the spawn locations
    public GameObject[] spawnPoints;

    // INSTANCES
    public static GameManager instance = null;

    // Check If there is an instance of GameManager otherwise then create one
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != null) {
            Destroy(gameObject);
        }
        // Adding any spawn points objects to the array
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    private void Start() {
        // Joining the player manually
        PlayerInputManager.instance.JoinPlayer(0, 0, null);
    }

    // Testing to see if player input is recognising their addition / subtraction
    void OnPlayerJoined(PlayerInput playerInput) {
        Debug.Log(" Player has just Joined the race!");
    }
    void OnPlayerLeft(PlayerInput playerInput) {
        Debug.Log(" Player has just Left the race!");
    }
}