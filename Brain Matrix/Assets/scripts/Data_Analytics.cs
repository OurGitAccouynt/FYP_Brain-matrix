using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AwesomeCharts;

public class Data_Analytics : MonoBehaviour
{
    int a;
    int b;
    public BarChart chart;
    public BarChart chart1;
    public BarChart chart2;
    public BarChart chart3;
    public BarChart chart4;

    int x = 1;
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
        populategraph();
  /*      Debug.Log(PlayerPrefs.GetInt("indexd"));
        Debug.Log(PlayerPrefs.GetInt("Scored" + 1));
        Debug.Log(PlayerPrefs.GetInt("Scored" + 0));
        Debug.Log(PlayerPrefs.GetInt("Scored" + 2));*/
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void adddatap()
    {
        PlayerPrefs.SetInt("temp", PlayerPrefs.GetInt("temp") + 1);
        x = PlayerPrefs.GetInt("temp");
        y = Random.Range(30, 60);
        chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
        chart.SetDirty();
    }
    public void adddatadr()
    {
        PlayerPrefs.SetInt("temp", PlayerPrefs.GetInt("temp") + 1);
        x = PlayerPrefs.GetInt("temp");
        y = Random.Range(30, 60);
        chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
        chart.SetDirty();
    }
    public void adddatado()
    {
        PlayerPrefs.SetInt("temp", PlayerPrefs.GetInt("temp") + 1);
        x = PlayerPrefs.GetInt("temp");
        y = Random.Range(30, 60);
        chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
        chart.SetDirty();
    }
    public void adddatam()
    {
        PlayerPrefs.SetInt("temp", PlayerPrefs.GetInt("temp") + 1);
        x = PlayerPrefs.GetInt("temp");
        y = Random.Range(30, 60);
        chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
        chart.SetDirty();
    }

    public void getinput()
    {


        for (int i = 1; i < 20; i++)
        {
            PlayerPrefs.SetInt("a" + i, i);
            PlayerPrefs.SetInt("b" + i, Random.Range(30, 60));
        }


        for (int i = 0; i < 20; i++)
        {


            x = PlayerPrefs.GetInt("a" + i);
            y = PlayerPrefs.GetInt("b" + i);
            chart.GetChartData().DataSets[0].AddEntry(new BarEntry(x, y));
            chart.SetDirty();
        }









    }
    public void populategraph() 
    {
        //////////////////////////////////////////////////////////////////////////////////////////Pluzzle

        for (int i = 1; i <= PlayerPrefs.GetInt("indexP"); i++)
        {
          a=PlayerPrefs.GetInt("CounterP" + i);
          b = PlayerPrefs.GetInt("ScoreP" + i);
          chart1.GetChartData().DataSets[0].AddEntry(new BarEntry(a, b));
          chart1.SetDirty();
        }
        //////////////////////////////////////////////////////////////////////////////////////////Dots

        for (int i = 1; i <= PlayerPrefs.GetInt("indexd"); i++)
        {
            a = PlayerPrefs.GetInt("Counterd" + i);
            b = PlayerPrefs.GetInt("Scored" + i);
            chart3.GetChartData().DataSets[0].AddEntry(new BarEntry(a, b));
            chart3.SetDirty();
        }

        //////////////////////////////////////////////////////////////////////////////////////////Maze

        for (int i = 1; i <= PlayerPrefs.GetInt("indexm"); i++)
        {
            a = PlayerPrefs.GetInt("Counterm" + i);
            b = PlayerPrefs.GetInt("Scorem" + i);
            chart2.GetChartData().DataSets[0].AddEntry(new BarEntry(a, b));
            chart2.SetDirty();
        }




        //////////////////////////////////////////////////////////////////////////////////////////Draw


        for (int i = 1; i <= PlayerPrefs.GetInt("indexpt"); i++)
        {
            a = PlayerPrefs.GetInt("Counterpt" + i);
            b = PlayerPrefs.GetInt("Scorept" + i);
            chart4.GetChartData().DataSets[0].AddEntry(new BarEntry(a, b));
            chart4.SetDirty();
        }







        //////////////////////////////////////////////////////////////////////////////////////////








        //////////////////////////////////////////////////////////////////////////////////////////








        //////////////////////////////////////////////////////////////////////////////////////////

    }
    public void Reset_data() 
    {
        PlayerPrefs.DeleteAll();
        populategraph();
    }
}
