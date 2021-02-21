using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDownScript : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    public int intTime;

    public Text countDownText;

    void Start() {
        currentTime = startingTime;
    }

    void Update() {
        currentTime -= 1 * Time.deltaTime;
        intTime = (int) Math.Round(currentTime);
        countDownText.text = intTime.ToString() + " seconds remaining";
        if (currentTime <= 0) {
            currentTime = 0;
            countDownText.color = Color.red;
        }
    }
}
