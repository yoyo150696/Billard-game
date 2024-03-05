using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer_s : MonoBehaviour
{
    public GetName gn;
    public TextMeshProUGUI t_timer;
    public GameOverScreen go;
    float timeLeft = 20.0f;

    bool isUpdateEnable = false;

    public void StartTimer(){
        isUpdateEnable = true;
        
    }
  
    // Update is called once per frame
    void Update()
    {
        if(isUpdateEnable){
            timeLeft -= Time.deltaTime;
            t_timer.text = (timeLeft).ToString("0");
            if(timeLeft < 0){
                int score = gn.Sc(8);
                go.Setup(score);
                isUpdateEnable = false;
            }
        }
    }
}
