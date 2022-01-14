using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailColliderSpawner : MonoBehaviour
{
    public GameObject colliderPrefab = null;            // S.B. Added null ref 
    public GameObject colliderSpawnLocation = null;    // S.B. Added null ref 

    public GameObject player = null;                    // S.B. Added null ref 
    public TrailRenderer carTrail;
    public GameObject colliderParent  = null;           // S.B. Added null ref 
    public GameObject objPickup = null;                 // S.B. Added null ref 

    public bool playerMoving = false;
    private float spawnTimer = 0f;
    private float spawnInterval;

    private float safePeriod = 8f;
    public float trailLength = 1f;


    // Start is called before the first frame update
    void Start()
    {
        carTrail.time = trailLength;
    }

    // Update is called once per frame
    void Update()
    {

        spawnInterval = 1 / GetComponent<CarMovement>().speed;
        if (GetComponent<CarMovement>().raceStarted) {
            safePeriod -= Time.deltaTime;
        }
        

        if(safePeriod <= 0) {
            carTrail.time -= (Time.deltaTime * 0.1f);
        }

        if(carTrail.time <= 0) {
            this.gameObject.GetComponent<CarMovement>().DestroyVehicle();
        }

        if (playerMoving) {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnInterval) {
                GameObject __Collider;
                __Collider = Instantiate(colliderPrefab, colliderSpawnLocation.transform.position, colliderSpawnLocation.transform.rotation);
                spawnTimer = 0;
                __Collider.transform.parent = colliderParent.transform;
                if(__Collider != null) {
                    Destroy(__Collider, carTrail.time);
                }
            }
        }
    }

    public void increaseTrailTime(float timeToAdd, GameObject objPickup) {

        carTrail.time += timeToAdd; //adds time onto the trail
        safePeriod = 5f; //increases the safe period so the trail doesn't keep losing immediately
        if (objPickup != null) {            //\--- S.B. Added Null reference check
            objPickup.transform.parent.parent.GetComponent<PickupSpawns>().objectSpawned = false; 
            Destroy(objPickup.transform.gameObject); //destroys the pickup and the parent object 
        }
        
    }


}
