using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailPickupSpawner : MonoBehaviour
{


    public List<GameObject> pickupSpawnLocations; //spawn locations
    public List<GameObject> pickups; //objects to spawn


    private float spawnInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in pickupSpawnLocations) {

            go.GetComponent<PickupSpawns>().objectSpawned = false;

        }
    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject go in pickupSpawnLocations) {
            if(go.GetComponent<PickupSpawns>().objectSpawned == false) {
                go.GetComponent<PickupSpawns>().timer -= Time.deltaTime;
            }
            
            if(go.GetComponent<PickupSpawns>().timer <= 0) {
                Instantiate(pickups[Random.Range(0, pickups.Count)], go.transform.position, go.transform.rotation, go.transform); //picks a random pickup object to spawn at each of the locations when the timer runs out
                go.GetComponent<PickupSpawns>().objectSpawned = true; //sets object spawned to be true, so that it wont keep spawning objects
                go.GetComponent<PickupSpawns>().timer = 5f; //resets the timer when it spawns an object
            }

        }

    }
}
