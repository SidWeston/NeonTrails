using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyCarAssign : MonoBehaviour
{
        [SerializeField] GameObject car1 = null;
        [SerializeField] private GameObject car2 = null;

        private void Start() {
            if (gameObject.name == ("Player 0")) {
                car1.gameObject.SetActive(true);
                car2.gameObject.SetActive(false);
            }
            
            if (gameObject.name == ("Player 1")) {
                car1.gameObject.SetActive(false);
                car2.gameObject.SetActive(true);
            }
        }
        


}
