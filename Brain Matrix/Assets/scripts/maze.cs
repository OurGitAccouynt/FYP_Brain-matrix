using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maze : MonoBehaviour
{
    public DueTime Score;
    public bool Mission2;
    public static int ScoreP;
    public bool first_level;
    public bool Analytics_level;
    public bool destory;
    void Start()
    {
        if (first_level)
        {
            ScoreP = 0;

        }
        ScoreP = ScoreP + Score.newtime;

        if (Analytics_level)
        {
            Analytics();

        }
        if (destory)
        {
           // destroyData();

        }

    }
    public void Analytics()
    {
        PlayerPrefs.SetInt("indexm", PlayerPrefs.GetInt("indexm") + 1);
        PlayerPrefs.SetInt("Counterm" + PlayerPrefs.GetInt("indexm"), PlayerPrefs.GetInt("Counterm") + PlayerPrefs.GetInt("indexm") );
        PlayerPrefs.SetInt("Scorem" + PlayerPrefs.GetInt("indexm"), ScoreP);
        ShowData();


    }
    public void ShowData()
    {
        Debug.Log("Index: " + PlayerPrefs.GetInt("indexm"));
        Debug.Log("Value of Y" + PlayerPrefs.GetInt("Counterm" + PlayerPrefs.GetInt("indexm")));
        Debug.Log("Score is X:" + PlayerPrefs.GetInt("Scorem" + PlayerPrefs.GetInt("indexm")));

    }
    public void destroyData()
    {
       // PlayerPrefs.DeleteAll();

    }
}
