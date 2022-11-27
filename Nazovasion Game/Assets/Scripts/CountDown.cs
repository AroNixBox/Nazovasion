using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    //for GameOverScreen
    //public GameObject objectToActivateAndDeactivate;
    //for timer
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] TMP_Text countdownText;

    public float CurrentTime
    {
        get => currentTime; set => currentTime = value;
    }
    void Start()
    {
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0.0");

        if (currentTime <= 3)
        {
            countdownText.color = Color.red;
        }
        else
        {
            countdownText.color = Color.white;
        }

        if (currentTime <= 0)
        {
            //want the game to stop >>> Time.timeScale = 0;
            //add here what you want to happen when time is over. For example we passed the level, Load new scene... Remember to use Using
            //GameOverScreen objectToActivateAndDeactivate.SetActive(true);
        }
    }
}
