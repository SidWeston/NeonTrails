using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDelay : MonoBehaviour {

    public static bool playClip;
    
    [SerializeField] private float timer;
    [SerializeField] private GameObject startAudio = null;

    private void Update() {
        if (timer > 0) {
            timer -= Time.deltaTime;
            if (timer <= 0) {
                startAudio.SetActive(true);
            }
        }
    }
    
}
