using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AwesomeCharts;
public class loop : MonoBehaviour
{

    public BarChart chart;
    int x=1;
    int y;
    int temp;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.DeleteAll();
      /*  for (int i = 0; i < 20; i++)
        {


            x = PlayerPrefs.GetInt("a" + i);
            y = PlayerPrefs.GetInt("b" + i);
            chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
            chart.SetDirty();
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void addnewdata() {
        PlayerPrefs.SetInt("temp" , PlayerPrefs.GetInt("temp")+1);
        x = PlayerPrefs.GetInt("temp");
        y = Random.Range(30, 60);
        chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
        chart.SetDirty();
    }

    public void getinput() {
       

        for (int i = 1; i <20; i++)
        {
            PlayerPrefs.SetInt("a"+i, i);
            PlayerPrefs.SetInt("b" + i, Random.Range(30, 60));
        }


        for (int i = 0; i < 20; i++)
        {


            x = PlayerPrefs.GetInt("a"+i);
            y = PlayerPrefs.GetInt("b" + i);
            chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
            chart.SetDirty();
        }

       



     



    }
}
