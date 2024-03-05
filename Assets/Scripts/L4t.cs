using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class L4t : MonoBehaviour
{
    public GetName gn;
    public TextMeshProUGUI t_timer;
    public L4go go;
    float timeLeft = 30.0f;

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
                isUpdateEnable = false; 
                go.Setup(gn.Get_score());
            }
        }
    }
}
