using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_change : MonoBehaviour
{
    public GameObject Test;
    public GameObject Menu;

    char score;
    public static int counter;

   
    public static string[] dataset = new string [26];
    public static string[] A = new string[26];
    public static string[] B = new string[26];
    public static string[] C = new string[26];
    public static string[] D = new string[26];
    public static int index;
    int[] check = new int[26];
    int count;
    int temp;
    static float marks;
    public Text Score_UIText;
    public  Text Score_A;
    public  Text Score_B;
    public  Text Score_C;
    public  Text Score_D;
    void Start()
    {
        marks = 0;
        count = 0;
        //Initializing
        
        Debug.Log("A");
        

        startingdata();

    }

    public void callData()
    {
       if (counter <= 10) { 


      System.Random random = new System.Random();
      index = random.Next(0, 25);

       for (int i = 0; i < check.Length; i++)
       {
           temp = i;
           if (check[i] == index)
           { break; }

        }       
        if (check[temp] == index)
       {
            callData();
        }
        getData();
      }
        Test.active = false;
        Menu.active = true;
        Debug.Log("score is :"+marks);

    }
    public void getData()
    {
      Text_change A1 = new Text_change();
       A1.Score_UIText.text = "afaffafafa";
       A1.Score_A.text = "afaffafafa";
       A1.Score_B.text = "afaffafafa";
       A1.Score_C.text = "afaffafafa";
       A1.Score_D.text = "afaffafafa";

    } 

    public void mainScore()
    {
        if (index == 1)
        {
            if (score == 'A')
            {
                marks++;
            }
            else 
            {
                callData();
            }

        }

        if (index == 2)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 3)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 4)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 5)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 6)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 7)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 8)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 9)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 10)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 11)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 12)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 13)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 14)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 15)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 16)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 17)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 18)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 19)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 20)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 21)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 22)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 23)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 24)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }

        if (index == 25)
        {
            if (score == 'A')
            {
                marks++;
            }
            else
            {
                callData();
            }
        }


    }
    public static void startingdata()
    {
        dataset[0] = "AF";
        A[0] = "AF";
        B[0] = "AF";
        C[0] = "AF";
        D[0] = "AF";

        dataset[1] = "AF";
        A[1] = "AF";
        B[1] = "AF";
        C[1] = "AF";
        D[1] = "AF";

        dataset[2] = "2A";
        A[2] = "2A";
        B[2] = "2A";
        C[2] = "2A";
        D[2] = "2A";

        dataset[3] = "AF";
        A[3] = "AF";
        B[3] = "AF";
        C[3] = "AF";
        D[3] = "AF";

        dataset[4] = "AF";
        A[4] = "AF";
        B[4] = "AF";
        C[4] = "AF";
        D[4] = "AF";

        dataset[5] = "AF";
        A[5] = "AF";
        B[5] = "AF";
        C[5] = "AF";
        D[5] = "AF";

        dataset[6] = "AF";
        A[6] = "AFAF";
        B[6] = "AF";
        C[6] = "AF";
        D[6] = "AF";

        dataset[7] = "AF";
        A[7] = "AF";
        B[7] = "AF";
        C[7] = "AF";
        D[7] = "AF";

        dataset[8] = "AF";
        A[8] = "AF";
        B[8] = "AF";
        C[8] = "AF";
        D[8] = "AF";

        dataset[9] = "AF";
        A[9] = "AF";
        B[9] = "AF";
        C[9] = "AF";
        D[9] = "AF";

        dataset[10] = "AF";
        A[10] = "AF";
        B[10] = "AF";
        C[10] = "AF";
        D[10] = "AF";

        dataset[11] = "AF";
        A[11] = "AF";
        B[11] = "AF";
        C[11] = "AF";
        D[11] = "AF";

        dataset[12] = "AF";
        A[12] = "AF";
        B[12] = "AF";
        C[12] = "AF";
        D[12] = "AF";

        dataset[13] = "AF";
        A[13] = "AF";
        B[13] = "AF";
        C[13] = "AF";
        D[13] = "AF";

        dataset[14] = "AF";
        A[14] = "AF";
        B[14] = "AF";
        C[14] = "AF";
        D[14] = "AF";

        dataset[15] = "AF";
        A[15] = "AF";
        B[15] = "AF";
        C[15] = "AF";
        D[15] = "AF";

        dataset[1] = "AF";
        A[16] = "AF";
        B[16] = "AF";
        C[16] = "AF";
        D[16] = "AF";


        dataset[17] = "AF";
        A[17] = "AF";
        B[17] = "AF";
        C[17] = "AF";
        D[17] = "AF";

        dataset[18] = "AF";
        A[18] = "AF";
        B[18] = "AF";
        C[18] = "AF";
        D[18] = "AF";

        dataset[19] = "AF";
        A[19] = "AF";
        B[19] = "AF";
        C[19] = "AF";
        D[19] = "AF";

        dataset[20] = "AF";
        A[20] = "AF";
        B[20] = "AF";
        C[20] = "AF";
        D[20] = "AF";

        dataset[21] = "AF";
        A[21] = "AF";
        B[21] = "AF";
        C[21] = "AF";
        D[21] = "AF";

        dataset[22] = "AF";
        A[22] = "AF";
        B[22] = "AF";
        C[22] = "AF";
        D[22] = "AF";

        dataset[23] = "AF";
        A[23] = "AF";
        B[23] = "AF";
        C[23] = "AF";
        D[23] = "AF";

        dataset[24] = "AF";
        A[24] = "AF";
        B[24] = "AF";
        C[24] = "AF";
        D[24] = "AF";

        dataset[25] = "AF";
        A[25] = "AF";
        B[25] = "AF";
        C[25] = "AF";
        D[25] = "AF";
    }
    public static void ScoreA()
    {
        Text_change A1 = new Text_change();
        Debug.Log("button A is clicked"+dataset[1]);
        Debug.Log(dataset[2]);
        A1.getData();
        // A1.score = 'A';
        // A1.counter++;
        // A1.mainScore();
    }
    public static void ScoreB()
    {
        Debug.Log("button B is clicked");
        //score = 'B';
        // counter++;
        //mainScore();
    }

    public static void ScoreC()
    {
        Debug.Log("button C is clicked");
        // score = 'C';
        //counter++;
        // mainScore();
    }

    public static void ScoreD()
    {
        Debug.Log("button D is clicked");
        // score = 'D';
        // counter++;
        // mainScore();
    }
}