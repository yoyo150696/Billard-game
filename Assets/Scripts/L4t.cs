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
  
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        t_timer.text = (timeLeft).ToString("0");
        if(timeLeft < 1){
            go.Setup(gn.Get_score());
        }
    }
}
