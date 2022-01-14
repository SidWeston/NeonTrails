using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//\--------------------------------------------------------------------------------
//    SCRIPT: LoadingScreen
//    Author: Scott Baldwin
//    Last Modified: 25/05/21
//    Brief: Simple IEnumerator timer allowing this scene to be active for the specified time 
//             before loading the next scene
//\--------------------------------------------------------------------------------

public class LoadingScreen : MonoBehaviour
{
    
    void Start() {
        StartCoroutine(LoadingTimer());
    }
    
    IEnumerator LoadingTimer() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
