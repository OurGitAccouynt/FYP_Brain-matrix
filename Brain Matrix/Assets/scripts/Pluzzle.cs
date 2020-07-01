using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluzzle : MonoBehaviour
{
    public EventManager Data;
    public EventManager2 Data2;
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
            ScoreP = ScoreP + Data.Movecounter;

        }
            if (Mission2) 
        {

            ScoreP = ScoreP + Data2.Movecounter;

        }
       

        if (Analytics_level) 
        {
            Analytics();
            
        }
        if (destory)
        {
          //  destroyData();

        }

    }
    public void Analytics() 
    {
        PlayerPrefs.SetInt("indexP", PlayerPrefs.GetInt("indexP") + 1);
        PlayerPrefs.SetInt("CounterP"+PlayerPrefs.GetInt("indexP"), PlayerPrefs.GetInt("CounterP") + PlayerPrefs.GetInt("indexP") );
        PlayerPrefs.SetInt("ScoreP" + PlayerPrefs.GetInt("indexP"), ScoreP);
        ShowData();
        

    }
    public void ShowData() 
    {
        Debug.Log("Index: "+PlayerPrefs.GetInt("indexP"));
        Debug.Log("Value of Y"+PlayerPrefs.GetInt("CounterP" + PlayerPrefs.GetInt("indexP")));
        Debug.Log("Score is X:"+PlayerPrefs.GetInt("ScoreP" + PlayerPrefs.GetInt("indexP")));
        
    }
    public void destroyData() 
    {
       // PlayerPrefs.DeleteAll();
       
    }
}
