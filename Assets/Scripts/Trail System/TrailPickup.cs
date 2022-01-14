using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailPickup : MonoBehaviour
{
    public float timeToGive = 0.5f; //amount of time to add onto the trail timer
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            //\-----------------------------------------------------
            // SB 26/05/21 - Added variable for audio collection
            //\-----------------------------------------------------
            SoundFXManager.playOrbSFX = true;
            //\-----------------------------------------------------
            GameObject carParent = other.GetComponent<CarSphere>().sphereParent.gameObject; //gets the original parent object of the sphere
            carParent.gameObject.GetComponent<TrailColliderSpawner>().increaseTrailTime(timeToGive, this.gameObject); //triggers a function in the trail collider script to increase the trail time
            
            
        }
    }
}
