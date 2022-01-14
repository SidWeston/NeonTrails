using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

// [ExecuteInEditMode]
public class MultiplayerCamera1 : MonoBehaviour {

    // Failed attempt of a custom Camera Controller (Multiplayer)    
    // public GameObject camera;
    // public GameObject player1 = null;
    // public GameObject player2 = null;
    //
    // public  Vector3 p1Pos;
    // public Vector3 p2Pos;
    // public Vector3 Pv;
    // public Vector3 PvN;
    // public Vector3 PlayMidPos;
    // public Vector3 camVec;
    // public Vector3 upVec = new Vector3(0, 1, 0);
    //
    // private float distance;
    // [SerializeField] private Vector3 disToCamera = new Vector3(0, 0, -30);
    //
    // // Update is called once per frame
    // void Update() {
    //     
    //     p1Pos = player1.transform.position;
    //     p2Pos = player2.transform.position;
    //     
    //     // Finding the Vector between p1 and p2
    //     Pv = p2Pos - p1Pos;
    //     Debug.Log("Direction to player one =" + Pv);
    //
    //     // Calculating the Magnitude of p1 and p2
    //     distance = Mathf.Sqrt(Pv.x * Pv.x + Pv.y * Pv.y + Pv.z * Pv.z);
    //     Debug.Log("magnitude of Pv = " + distance);
    //
    //     // Normalising Pv
    //     PvN = Pv / distance;
    //     Debug.Log("Pv Normalised = " + PvN);
    //
    //     VectorDivision();
    //     PlayMidPos = p1Pos + (PvN * (distance / 2f));
    //     Debug.Log( "Q is = " + PlayMidPos);
    //
    //     QCrossProduct();
    //     Debug.Log("camVec is: " + camVec);
    //     
    // }
    //
    // // Dividing the camera in two to find the centre point
    // Vector3 VectorDivision() {
    //
    //     PlayMidPos.x = (p1Pos.x + p2Pos.x) / 2;
    //     PlayMidPos.y = (p1Pos.y + p2Pos.y) / 2;
    //     PlayMidPos.z = (p1Pos.z + p2Pos.z) / 2;
    //     
    //     return PlayMidPos;
    // }
    // // finding the angle between two players using Cross-product formula 
    // Vector3 QCrossProduct() {
    //
    //     camVec.x = (PvN.y * upVec.z - PvN.z * upVec.y);
    //     camVec.y = (PvN.z * upVec.x - PvN.x * upVec.z);
    //     camVec.z = (PvN.x * upVec.y - PvN.y * upVec.x);
    //
    //     return camVec;
    // }
}
