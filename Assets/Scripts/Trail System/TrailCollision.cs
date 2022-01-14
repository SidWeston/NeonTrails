using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCollision : MonoBehaviour
{
    [HideInInspector]
    public float damageToGive = 25;
    private bool canDamage = false;

    private float damageTimer = 1f;

    private void Update() {

        damageTimer -= Time.deltaTime;
        if(damageTimer <= 0) {
            canDamage = true;
        }

    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" && canDamage) {
            GameObject carParent = other.GetComponent<CarSphere>().sphereParent.gameObject;
            carParent.gameObject.GetComponent<CarMovement>().overlappingObjects.Add(this.gameObject);
            
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player" && canDamage) {
            GameObject carParent = other.GetComponent<CarSphere>().sphereParent.gameObject;
            carParent.gameObject.GetComponent<CarMovement>().overlappingObjects.Remove(this.gameObject);

        }
    }


}
