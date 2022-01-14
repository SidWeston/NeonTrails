using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variables
    public float movementSpeed = 10f;
    public float spawnInterval = 0.01f;
    public float gravity = -9.8f;
    public GameObject colliderPrefab;
    public GameObject colliderSpawnLocation;

    //private variables
    private bool playerMoving = false;
    private float spawnTimer = 0f;
    private Vector3 velocity = new Vector3(0, 0, 0);

    //ground check
    //bool isGrounded;
    //public Transform groundCheck;
    //public float groundDistance = 0.4f;
    //public LayerMask groundMask;


    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horizontalInput, 0, verticalInput);

        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if (isGrounded && velocity.y < 0) {
        //    velocity.y = -2f;
        //}

        if (playerMovement.x != 0 || playerMovement.z != 0) {
            playerMoving = true;
        }
        else if (playerMovement.x == 0 && playerMovement.z == 0) {
            playerMoving = false;
        }

        if (playerMoving) {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnInterval) {
                Instantiate(colliderPrefab, colliderSpawnLocation.transform.position, colliderSpawnLocation.transform.rotation);
                spawnTimer = 0;
            }
        }

        transform.LookAt(playerMovement + transform.position);
        transform.Translate(playerMovement * movementSpeed * Time.deltaTime, Space.World);
        
        //creates gravity
        //velocity.y += gravity;
        

    }
}
