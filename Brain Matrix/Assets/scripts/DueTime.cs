using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DueTime : MonoBehaviour
{

   public float nextUpdate=1;
   public int timemaze;
    public Text time;
    public Text time2;
    [HideInInspector]
    public int newtime;
    public GameObject lose;
    bool lose_game;

    private void Awake()
    {
        newtime = 1000;
        lose_game = true;
    }
    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            Debug.Log(Time.time + ">=" + nextUpdate);
          
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
           
            UpdateEverySecond();
        }
        time.text = timemaze.ToString();
        
        time2.text = newtime.ToString();
        if (newtime <= 0) 
        {
            lose.SetActive(true);
            lose_game = false;

        }

    }

   
    void UpdateEverySecond()
    {
        if (lose_game) 
        { 
        timemaze++;
        newtime-=8;
        }


    }

}