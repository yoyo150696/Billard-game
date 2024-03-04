using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class L4go : MonoBehaviour
{
    public TextMeshProUGUI t_score;
    
    public void Setup(int points){
        gameObject.SetActive(true);
        t_score.text = "your score is " + points.ToString();
    }
}
