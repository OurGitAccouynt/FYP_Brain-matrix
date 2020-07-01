using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{

    public bool Mission2;
    public static int ScoreP;
    public bool first_level;
    public bool Analytics_level;
    public bool destory;
    void Start()
    {
        ScoreP = 0;
        InvokeRepeating("ThisMethod", 0, 2);
     

    }
    public void Analytics()
    {
        PlayerPrefs.SetInt("indexd", PlayerPrefs.GetInt("indexd") + 1);
        PlayerPrefs.SetInt("Counterd" + PlayerPrefs.GetInt("indexd"), PlayerPrefs.GetInt("Counterd") + PlayerPrefs.GetInt("indexd"));
        PlayerPrefs.SetInt("Scored" + PlayerPrefs.GetInt("indexd"), ScoreP);
        ShowData();
        CancelInvoke();


    }
    public void ShowData()
    {
        Debug.Log("Index: " + PlayerPrefs.GetInt("indexd"));
        Debug.Log("Value of Y" + PlayerPrefs.GetInt("Counterd" + PlayerPrefs.GetInt("indexd")));
        Debug.Log("Score is X:" + PlayerPrefs.GetInt("Scored" + PlayerPrefs.GetInt("indexd")));

    }
    public void destroyData()
    {
        //PlayerPrefs.DeleteAll();

    }
    public void ThisMethod()
    {
        ScoreP = ScoreP + 2;
    }
    public void EndAnalytics()
    {
        if (Analytics_level)
        {
            Analytics();
            CancelInvoke();
        }

    }
}

