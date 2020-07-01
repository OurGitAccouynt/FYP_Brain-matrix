using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paint : MonoBehaviour
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
        if (first_level)
        {
            ScoreP = 0;

        }
    
        if (destory)
        {
           // destroyData();

        }

    }
    public void Analytics()
    {
        PlayerPrefs.SetInt("indexpt", PlayerPrefs.GetInt("indexpt") + 1);
        PlayerPrefs.SetInt("Counterpt" + PlayerPrefs.GetInt("indexpt"), PlayerPrefs.GetInt("Counterpt") + PlayerPrefs.GetInt("indexpt") );
        PlayerPrefs.SetInt("Scorept" + PlayerPrefs.GetInt("indexpt"), ScoreP);
        ShowData();


    }
    public void ShowData()
    {
        Debug.Log("Index: " + PlayerPrefs.GetInt("indexpt"));
        Debug.Log("Value of Y" + PlayerPrefs.GetInt("Counterpt" + PlayerPrefs.GetInt("indexpt")));
        Debug.Log("Score is X:" + PlayerPrefs.GetInt("Scorept" + PlayerPrefs.GetInt("indexpt")));

    }
    public void destroyData()
    {
       // PlayerPrefs.DeleteAll();

    }
    public void ThisMethod() 
    {
        ScoreP = ScoreP + 5;
  

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
