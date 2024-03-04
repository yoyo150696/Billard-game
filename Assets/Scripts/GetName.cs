using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GetName : MonoBehaviour
{
    public TextMeshProUGUI t_score;
    public TextMeshProUGUI t_color;
    private Rigidbody2D[] rbs;
    public List<string> colors = new List<string>();
    // Start is called before the first frame update
    int score;

    public void Rescore(string color_name){
        if(color_name == "White"){
            score--;
        }
        else if(color_name == t_color.text){
            score+= 2;
        }
        else{
            score++;
        }
        
        t_score.text = score.ToString();   

    }
    public void Getn (){
        var rnd = new System.Random();
        int index = rnd.Next(colors.Count);
        t_color.text = colors[index];  
        
    }
    public int Get_score(){
        return score;
    }
    private void Regroup(){
        colors.Clear();
        rbs = gameObject.GetComponentsInChildren<Rigidbody2D>();
        foreach(Rigidbody2D r in rbs){
            if(r.name != "White")
                colors.Add(r.name);
        }
    }
    public int Sc(int all){
        Regroup();
        return all-colors.Count();
    }
    public void Ren(){
        Regroup();
        Getn();
    }
    void Start(){
        Ren();
        score = 0;
        t_score.text = score.ToString();
        
    }
}
