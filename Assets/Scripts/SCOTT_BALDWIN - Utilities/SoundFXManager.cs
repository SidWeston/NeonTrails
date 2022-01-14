using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour {
    
    [SerializeField] private GameObject orbSfx;
    [SerializeField] private float timer = 1f;

    public static bool playOrbSFX = false;

    private void FixedUpdate() {
       
        if (playOrbSFX) {
            
            orbSfx.SetActive(true); 
            timer -= Time.deltaTime;
        }
        if (timer <= 0) {
            orbSfx.SetActive(false);
            timer = 1f;
            playOrbSFX = false;
        }
    }
}
