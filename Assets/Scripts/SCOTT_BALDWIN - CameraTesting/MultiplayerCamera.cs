using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//\--------------------------------------------------------------------------------
//    SCRIPT: MultiplayerCamera
//    Author: Scott Baldwin
//    Last Modified: 20/03/21
//    Brief: Custom Camera script for a joint camera for races
//\--------------------------------------------------------------------------------
public class MultiplayerCamera : MonoBehaviour {
   // Creating a List of all the targets we want to follow called: targets
   public List<Transform> targets;

   // Offset of camera away from targets
   [SerializeField] Vector3 offset;
   [SerializeField] float smoothTime = .5f;
   [SerializeField] float minZoom = 40f;
   [SerializeField] float maxZoom = 10f;
   [SerializeField] float zoomLimiter = 10f;
   
   private Vector3 velocity;
   private Camera racingCamera;

   void Start() {
      racingCamera = GetComponent<Camera>();
   }

   void Update() {
      // TO DO CALCULATE THE VECTOR OF THE FURTHEST TWO OBJECTS AND CALCULATE THE CROSS PRODUCT 
      //transform.LookAt(targets);
   }
   

   // Using LateUpdate as we want the camera to move last
   
   void LateUpdate() {

      if (targets.Count == 0) {
         return;
         
      }
      Move();
      Zoom();
   }
   
   // Setting our camera position to the centre of all points (targets) using GetCentrePoint Function
   void Move() {
      Vector3 centrePoint = GetCentrePoint();

      Vector3 newPosition = centrePoint + offset;
      // Smoothing from pos2pos using 'SmoothDamp' using velocity as a referenced Vector
      transform.position = Vector3.SmoothDamp(transform.position, newPosition,  ref velocity, smoothTime);
   }
   void Zoom() {
      Debug.Log(GetGreatestDistance());
      float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
      racingCamera.fieldOfView = Mathf.Lerp(racingCamera.fieldOfView, newZoom, Time.deltaTime);
   }

   float GetGreatestDistance() {
      var bounds = new Bounds(targets[0].position, Vector3.zero);
      for (int i = 0; i < targets.Count; i++) {
         bounds.Encapsulate(targets[i].position);
      }
      return bounds.size.z;
   }
   
   Vector3 GetCentrePoint() {
      // Check to make sure there are multiple targets to follow - (Winner sequence)
      if (targets.Count == 1) {
         return targets[0].position;
      }
      // Setting the bounding box of the total targets - Starting at the centre of the first [0]
      var bounds = new Bounds(targets[0].position, Vector3.zero);
      // Resizing the bounding box using a for Loop for all  targets 
      for (int i = 0; i < targets.Count; i++) {
         bounds.Encapsulate(targets[i].position);
      }

      return bounds.center;
   }


}
