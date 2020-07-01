using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class data : MonoBehaviour
{
    public GameObject Test;
    public GameObject Menu;
    public GameObject nodementia;

    public GameObject somedementia;

    public GameObject highdementia;
    public static string[] dataset = new string[26];
    public static string[] A = new string[26];
    public static string[] B = new string[26];
     public static int[] check = new int[26];
    public static int marks = 0;
    public List<int> randomList = new List<int>();

    public Text Score_UIText;
    public Text Score_A;
    public Text Score_B;
    
    public static int counter = 0;
    int index;
 
 

    void Start()
    {
        dataset[0] = "Do you ever forget information that you have learned recently?";
        A[0] = "YES";
        B[0] = "NO";
       

        dataset[1] = "Do you have to ask for the same information again or need reminder notes?";
        A[1] = "YES";
        B[1] = "NO";
         

        dataset[2] = "Do you have trouble following instructions, like a recipe or directions??";
        A[2] = "YES";
        B[2] = "NO";
        

        dataset[3] = "Do you struggle to keep track of finances or pay bills on time?";
        A[3] = "YES";
        B[3] = "NO";
         

        dataset[4] = "Do you experience visual problems, such as trouble with reading or judging distance or color?";
        A[4] = "YES";
        B[4] = "NO";
        

        dataset[5] = "Do you find yourself becoming confused in the middle of a conversation and having to stop?";
        A[5] = "YES";
        B[5] = "NO";
    


        dataset[6] = "Do you struggle to remember words, date, or events?";
        A[6] = "YES";
        B[6] = "NO";
 


        dataset[7] = "Do you lose things and/or sense that people have stolen them?";
        A[7] = "YES";
        B[7] = "NO";
 

        dataset[8] = "Have you or others noticed changes in your personality, such as becoming easily upset or anxious? ";
        A[8] = "YES";
        B[8] = "NO";
   


        callData();
    
    }

    void Update()
    {

        
        if (AA.mcq == 'A')
        {
               
            AA.mcq = 'E';
            callData();

        }

        if (AA.mcq == 'B')
        {


            marks++;
            AA.mcq = 'E';
            callData();
        }

        

 
    }
    public void callData()
    {
  
        if (counter <= 7)
        {


            index++;
            getData();
            
            
        }
        else
        {
            if (marks > 5) {
                nodementia.SetActive(true);
            }
            if (marks == 5 || marks == 4)
            {

                somedementia.SetActive(true);
            }
            if (marks < 4) {
                highdementia.SetActive(true);
            }

        }
    }
    public void getData()
    {
        counter++;
        Score_UIText.text = dataset[index];
        Score_A.text = A[index];
        Score_B.text = B[index]; 
    }
}
