using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RaceManager : MonoBehaviour
{

    private float raceTimer = 5; //start of race countdown
    private float uiCountdown = 2; //how long the ui will stay up for when the race starts
    static bool winnerDeclared;  //if there is a winner of the race/round

    public List<GameObject> raceCars; //list of the cars in the scene
    private GameObject[] players;

    public CanvasGroup uiCanvasGroup = null;
    public Text countdownText = null;

    private float timer = 5;

    // SB ADDED WIN CONDITION


    // Start is called before the first frame update
    void Awake() 
    {
        timer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (raceTimer > 0)
        {
            raceTimer -= Time.deltaTime; //counts down at the start of the race
            if (countdownText != null)
            {
                countdownText.text = raceTimer.ToString();
            }

        }

        if (raceTimer <= 0 && uiCanvasGroup.alpha > 0)
        {
            countdownText.text = "Go!";
            uiCountdown -= Time.deltaTime;
            if (uiCountdown <= 0)
            {
                uiCanvasGroup.alpha = 0;
            }
        }

        if (raceTimer <= 0 && raceCars.Count != 0)
        {
            foreach (GameObject car in raceCars)
            {

                car.GetComponent<CarMovement>().raceStarted = true;
                if (car.GetComponent<CarMovement>().carTrail.time <= 0)
                {
                    raceCars.Remove(car);
                    Debug.Log(car);
                    Debug.Log("Reached Zero");
                }

            }
        }

        if (raceCars.Count == 1)
        {
            uiCanvasGroup.alpha = 1;
            countdownText.text = "THE WINNER IS: " + raceCars[0].gameObject.name;
            winnerDeclared = true;
        }

        if (winnerDeclared)
        {

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene("01.MAIN MENU  - SCOTT BALDWIN");
            }

        }

    }
}
