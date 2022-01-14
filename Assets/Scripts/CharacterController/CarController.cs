using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public enum Axel {
    Front,
    Rear
}

[Serializable]
public struct Wheel {
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
}

public class CarController : MonoBehaviour
{
    
    
    //variables
    [SerializeField]
    private float maxAcceleration = 20f;
    [SerializeField]
    private float turnSensitivity = 1f;
    [SerializeField]
    private float maxSteerAngle = 45f;
    [SerializeField]
    private List<Wheel> wheels;
    //\------------------------------------------
    // Added by Scott 24-05-21
    // Gameobject prefab access for instantiation
    [SerializeField] GameObject carPrefab = null;

    private float inputX, inputY;

    private Rigidbody rb;
    private bool handbrake = false;

    private bool isTurning = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var wheel in wheels) {
            wheel.collider.ConfigureVehicleSubsteps(5, 12, 15); //changes the number of sub-step calculations done by the wheels when using suspension. stops/reduces the car shaking when moving
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetInputs();

        if (Input.GetKey(KeyCode.Space)) { //is player pressing handbrake button
            handbrake = true;
        }else if (!Input.GetKey(KeyCode.Space)) {
            handbrake = false;
        }

    }

    private void FixedUpdate() { //use fixed update for physics collisions
        Move();
        Turn();
    }

    private void GetInputs() {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }

    private void Move() {
        foreach(var wheel in wheels) {
            if (!handbrake) { //if handbrake is up
                wheel.collider.motorTorque = inputY * maxAcceleration * 500 * Time.deltaTime;
                wheel.collider.brakeTorque = 0f;
            } else if (handbrake) { //handbrake down
                wheel.collider.brakeTorque = 3000f;
                wheel.collider.motorTorque = 0f;
            }
        }
    }

    private void Turn() {
        foreach(var wheel in wheels) {
            if(wheel.axel == Axel.Front) {
                var _steerAngle = inputX * turnSensitivity * maxSteerAngle;
                wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, _steerAngle, 0.5f);
                if(wheel.collider.steerAngle != 0) {
                    
                }
            }
        }
    }

    

}
