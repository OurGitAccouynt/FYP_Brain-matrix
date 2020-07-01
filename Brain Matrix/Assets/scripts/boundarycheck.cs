using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boundarycheck : MonoBehaviour
{
    public GameObject winpaneldisplay;
    public GameObject GameOver;
    public static bool a;
    public static bool b;
    public static bool c;
    public static bool d;
  
    private void Update()
    {


        if (a==true && b==true && c==true && d==true) {
            winpaneldisplay.SetActive(true);


        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "2left"  ) {


            Debug.Log("1 and 2 connected");
            a = true;

        }
        if (other.tag == "3top")
        {


            Debug.Log("3rd and first connected");
            b = true;
        }

        if (other.tag == "4left")
        {


            Debug.Log("3rd and fourth connected");
            c = true;
        }

        if (other.tag == "2down")
        {


            Debug.Log("2nd and fourth connected");
            d = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {


        if (other.tag == "2down")
        {


            Debug.Log("2nd and fourth connected");
            d = false;
        }

        if (other.tag == "2left")
        {


             a = false;

        }
        if (other.tag == "3top")
        {


             b = false;
        }

        if (other.tag == "4left")
        {


             c = false;
        }

    }
}
