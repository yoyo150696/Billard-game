using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI t_score;
    
    public void Setup(int points){
        gameObject.SetActive(true);
        if(points > 2 )
            t_score.text = "bravo,you won!!";
        else
            t_score.text = "you failed:(";

    }
}
