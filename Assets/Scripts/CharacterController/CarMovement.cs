using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarMovement : MonoBehaviour
{
    
    [SerializeField]
    private Rigidbody carRB; //the rigidbody for the car

    public TrailRenderer carTrail;

    private float turnStrength = 180;
    private float gravityForce = 10f;
    private float dragOnGround = 3f;
    public float speed = 0f; //current speed of vehicle
    private float maxSpeed = 85f; //max speed
    private float maxReverseSpeed = -25f; //max reverse speed
    private float acceleration = 10f; //acceleration
    private float accelerationMultiplier; //the percent at which the button is being pressed for acceleration
    private bool isAccelerating = false;
    [SerializeField]
    private Transform leftFrontWheel, rightFrontWheel, leftBackWheel, rightBackWheel; //references to the wheels
    [SerializeField]
    private float maxWheelTurn; //the maximum amount the wheels can turn in degrees

    private float turnInput; //turn input amount

    private bool grounded; //is the player on the ground?
    public LayerMask whatIsGround;
    public float groundRayLength = 0.5f;
    public Transform groundRayPoint; //where the ray for the ground check starts

    private bool handbrake = false;
    private float aButtonPressed = 0; //unity new input system takes inputs which can be converted to a float value

    public float health = 100f;
    public bool takenDamage = false;

    private float damageCooldownTimer = 4f;

    public bool isDestroyed = false;

    public bool raceStarted = false;

    [SerializeField]
    private GameObject sphereStart;

    [HideInInspector]
    public List<GameObject> overlappingObjects;

    // Start is called before the first frame update
    void Start()
    {
        carRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {

        if (carTrail.time > 0 && raceStarted) {
            if (speed > 0) {

                GetComponent<TrailColliderSpawner>().playerMoving = true;

                //rotates the wheels when the car moves forward
                leftBackWheel.Rotate(0, 0, 0.1f * speed);
                rightBackWheel.Rotate(0, 0, 0.1f * speed);
                leftFrontWheel.Rotate(0, 0, 0.1f * speed);
                rightFrontWheel.Rotate(0, 0, 0.1f * speed);

            } else if (speed < 0) {

                GetComponent<TrailColliderSpawner>().playerMoving = true;

                //rotates the wheels when the car moves backwards
                leftBackWheel.Rotate(0, 0, -0.1f * speed);
                rightBackWheel.Rotate(0, 0, -0.1f * speed);
                leftFrontWheel.Rotate(0, 0, -0.1f * speed);
                rightFrontWheel.Rotate(0, 0, -0.1f * speed);

            }

            if (turnInput > 0.1 || turnInput < -0.1) {
                acceleration = 4f; //car accelerates slower if they are turning
                if (!isAccelerating && speed > 0) {
                    speed -= 12 * Time.deltaTime;
                }
            } else {
                acceleration = 10f; //reverts back to normal acceleration rate when the car isnt turning
            }

            if (accelerationMultiplier > 0 && !handbrake) { //forward acceleration
                isAccelerating = true;
                if (speed < maxSpeed) {
                    speed += (acceleration * accelerationMultiplier) * Time.deltaTime;
                }
            } else if (accelerationMultiplier < 0 && !handbrake) { //backward acceleration
                isAccelerating = true;
                if (speed > maxReverseSpeed) {
                    speed += (acceleration * accelerationMultiplier) * Time.deltaTime;
                }
            } else if (accelerationMultiplier == 0 && !handbrake) { //if no acceleration is being applied in either direction
                isAccelerating = false;
                if (speed > 0) {
                    speed -= acceleration * Time.deltaTime * 0.75f;
                    if (speed < 0.05 && speed > -0.05) {
                        speed = 0; //stops the car if no acceleration is being applied and the speed is below a specific threshold
                    }
                }

            }

            if (speed < 0.1f && speed > -0.1f) { //if player is nearly stopped
                GetComponent<TrailColliderSpawner>().playerMoving = false; //sometimes the rigidbody velocity wont exactly equal 0
            }


            if (handbrake && speed > 0) {
                speed -= acceleration * Time.deltaTime * 3f; //decelerate fastest
                if (speed < 0) {
                    speed = 0; //sets speed to 0 if it falls below whilst using the handbrake
                }
            }

            if (grounded && carRB.velocity.magnitude > 0) {
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime, 0f));
            }

            transform.position = carRB.transform.position;

            if (health <= 0) {

                DestroyVehicle();

            }

            if (overlappingObjects.Count == 1 && !takenDamage) { //this activates when the player overlaps with someone elses trail, or their own trail
                Debug.Log("Collided");
                takenDamage = true;
                speed /= 2;
            }

            if (takenDamage) {
                damageCooldownTimer -= Time.deltaTime;

                if (damageCooldownTimer <= 0) {
                    takenDamage = false;
                    damageCooldownTimer = 4f;
                }
            }

            //turns the front wheels when the car turns
            leftFrontWheel.localRotation = Quaternion.Euler(leftFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn) - 270, leftFrontWheel.localRotation.eulerAngles.z);
            rightFrontWheel.localRotation = Quaternion.Euler(rightFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn) - 90, rightFrontWheel.localRotation.eulerAngles.z);

        }
        if(carTrail.time <= 0 && speed > 0) {
            speed -= acceleration * Time.deltaTime * 1.5f;//decelerates the car when the trail has run out
            if(speed < 0) {
                speed = 0;
            }
        }

    }

    private void FixedUpdate() {

        /*grounded = false;*/ //resets grounded every frame, then performs the ground check immediately. If the check comes true it will become true again
        grounded = Physics.CheckSphere(groundRayPoint.position, groundRayLength, whatIsGround);
        //RaycastHit hit;

        //if(Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLength, whatIsGround)) {
        //    grounded = true;

        //    transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        //}

        if (grounded) {
            carRB.drag = dragOnGround;

            if (Mathf.Abs(speed) > 0) {

                carRB.AddForce(transform.forward * speed * 100f);
            }
        } 
        else {

            carRB.drag = 0.1f;

            carRB.AddForce(Vector3.up * -gravityForce * 100f);
        }


        if(overlappingObjects.Count > 0 && !takenDamage) {
            Debug.Log("Taken Damage");
            takenDamage = true;
            speed /= 2;

        }


    }



    //these functions are for inputs, using the new unity input system. They convert the inputs into usable pieces of data
    public void OnAccelerate(InputAction.CallbackContext context) {

        accelerationMultiplier = context.ReadValue<float>();

    }

    public void OnHandbrake(InputAction.CallbackContext context) {

        aButtonPressed = context.ReadValue<float>();
        
        if(aButtonPressed > 0) {
            handbrake = true;
        }else {
            handbrake = false; 
        }

    }

    public void OnTurn(InputAction.CallbackContext context) {

        turnInput = context.ReadValue<float>();

    }


    public void DestroyVehicle() {

        isDestroyed = true;

    }
}
