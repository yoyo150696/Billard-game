using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void L1(){
        SceneManager.LoadScene("Level_1");
    }
    public void L2(){
        SceneManager.LoadScene("Level_2");
    }
    public void L3(){
        SceneManager.LoadScene("Level_3");
    }
    public void L4(){
        SceneManager.LoadScene("Level_4");
    }
    public void Menu(){
        SceneManager.LoadScene("MainMenu");
    }
}
