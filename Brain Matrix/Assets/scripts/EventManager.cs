using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject A_Glow;
    public GameObject B_Glow;
    public GameObject C_Glow;
    public GameObject D_Glow;
    public static bool OBJ1;
    public static bool OBJ2;
    public static bool OBJ3;
    public static bool OBJ4;
    private Material Temp1;
    private Material Temp2;
    public int Temp1int;
    public int Temp2int;


    public int sqA;
    public int sqB;
    public int sqC;
    public int sqD;
    public GameObject Winpanel;
    public GameObject Losepanel;
    public int Movecounter;
    public Text Movecounterui;
    Identifier a1;
    Identifier a2;
    Identifier a3;
    Identifier a4;



    public void Start()
    {
        a1 = A.GetComponent<Identifier>();
        a2 = B.GetComponent<Identifier>();
        a3 = C.GetComponent<Identifier>();
        a4 = D.GetComponent<Identifier>();
        OBJ1 = false;
        OBJ2 = false;
        OBJ3 = false;
        OBJ4 = false;
       // A.GetComponent<MeshRenderer>().material = sqA;


    }
    public void onA() 
    {
        OBJ1 = true;
        A_Glow.SetActive(true);
        

    }

    public void onB()
    {
        OBJ2 = true;
        B_Glow.SetActive(true);
        
    }

    public void onC()
    {
        OBJ3 = true;
        C_Glow.SetActive(true);
        
    }

    public void onD()
    {
        OBJ4 = true;
        D_Glow.SetActive(true);
        
    }
    public void Update()
    {
        Movecounterui.text = Movecounter.ToString();
        if (OBJ1 == true && OBJ2 == true) 
        {
            //Temp1 = A.GetComponent<Material>();
            //Temp2 = B.GetComponent<Material>();
            Temp1 = A.GetComponent<MeshRenderer>().material;
            Temp2 = B.GetComponent<MeshRenderer>().material;
            A.GetComponent<MeshRenderer>().material = Temp2;
            B.GetComponent<MeshRenderer>().material = Temp1;
            Temp1int =a1.identify;
            Temp2int =a2.identify;
            a1.identify = Temp2int;
            a2.identify = Temp1int;
            //A.GetComponent<Material>();
 OBJ1 = false;
            OBJ2 = false;
            OBJ3 = false;
            OBJ4 = false;
            A_Glow.SetActive(false);
            B_Glow.SetActive(false);
            C_Glow.SetActive(false);
            D_Glow.SetActive(false);
            Movecounter--;
        }

        if (OBJ1 == true && OBJ3 == true)
        {
            //Temp1 = A.GetComponent<Material>();
            //Temp2 = C.GetComponent<Material>();
            Temp1 = A.GetComponent<MeshRenderer>().material;
            Temp2 = C.GetComponent<MeshRenderer>().material;
            A.GetComponent<MeshRenderer>().material = Temp2;
            C.GetComponent<MeshRenderer>().material = Temp1;
            Temp1int = a1.identify;
            Temp2int = a3.identify;
            a1.identify = Temp2int;
            a3.identify = Temp1int;
            OBJ1 = false;
            OBJ2 = false;
            OBJ3 = false;
            OBJ4 = false;
            A_Glow.SetActive(false);
            B_Glow.SetActive(false);
            C_Glow.SetActive(false);
            D_Glow.SetActive(false);
            Movecounter--;
        }

        if (OBJ1 == true && OBJ4== true)
        {
            //Temp1 = A.GetComponent<Material>();
            //Temp2 = D.GetComponent<Material>();
            Temp1 = A.GetComponent<MeshRenderer>().material;
            Temp2 = D.GetComponent<MeshRenderer>().material;
            A.GetComponent<MeshRenderer>().material = Temp2;
            D.GetComponent<MeshRenderer>().material = Temp1;
            Temp1int = a1.identify;
            Temp2int = a4.identify;
            a1.identify = Temp2int;
            a4.identify = Temp1int;
            OBJ1 = false;
            OBJ2 = false;
            OBJ3 = false;
            OBJ4 = false;
            A_Glow.SetActive(false);
            B_Glow.SetActive(false);
            C_Glow.SetActive(false);
            D_Glow.SetActive(false);
            Movecounter--;
        }

        if (OBJ2== true && OBJ3 == true)
        {
           // Temp1 = B.GetComponent<Material>();
            //Temp2 = C.GetComponent<Material>();
            Temp1 = B.GetComponent<MeshRenderer>().material;
            Temp2 = C.GetComponent<MeshRenderer>().material;
            B.GetComponent<MeshRenderer>().material = Temp2;
            C.GetComponent<MeshRenderer>().material = Temp1;
            Temp1int = a2.identify;
            Temp2int = a3.identify;
            a2.identify = Temp2int;
            a3.identify = Temp1int;
            OBJ1 = false;
            OBJ2 = false;
            OBJ3 = false;
            OBJ4 = false;
            A_Glow.SetActive(false);
            B_Glow.SetActive(false);
            C_Glow.SetActive(false);
            D_Glow.SetActive(false);
            Movecounter--;
        }

        if (OBJ2 == true && OBJ4 == true)
        {
           // Temp1 = B.GetComponent<Material>();
            //Temp2 = D.GetComponent<Material>();
            Temp1 = B.GetComponent<MeshRenderer>().material;
            Temp2 = D.GetComponent<MeshRenderer>().material;
            B.GetComponent<MeshRenderer>().material = Temp2;
            D.GetComponent<MeshRenderer>().material = Temp1;
            Temp1int = a2.identify;
            Temp2int = a4.identify;
            a2.identify = Temp2int;
            a4.identify = Temp1int;
            OBJ1 = false;
            OBJ2 = false;
            OBJ3 = false;
            OBJ4 = false;
            A_Glow.SetActive(false);
            B_Glow.SetActive(false);
            C_Glow.SetActive(false);
            D_Glow.SetActive(false);
            Movecounter--;
        }

        if (OBJ3 == true && OBJ4 == true)
        {
            //Temp1 = C.GetComponent<Material>();
            //Temp2 = D.GetComponent<Material>();
            Temp1 = C.GetComponent<MeshRenderer>().material;
            Temp2 = D.GetComponent<MeshRenderer>().material;
            C.GetComponent<MeshRenderer>().material = Temp2;
            D.GetComponent<MeshRenderer>().material = Temp1;
            Temp1int = a3.identify;
            Temp2int = a4.identify;
            a3.identify = Temp2int;
            a4.identify = Temp1int;
            OBJ1 = false;
            OBJ2 = false;
            OBJ3 = false;
            OBJ4 = false;
            A_Glow.SetActive(false);
            B_Glow.SetActive(false);
            C_Glow.SetActive(false);
            D_Glow.SetActive(false);
            Movecounter--;

        }
       // if (A.GetComponent<Material>() == sqA.GetComponent<Material>() && B.GetComponent<Material>() == sqB.GetComponent<Material>() && C.GetComponent<Material>() == sqC.GetComponent<Material>() && D.GetComponent<Material>() == sqD.GetComponent<Material>()) 
       // {
         //   Winpanel.SetActive(true);
        
       // }
        if (Movecounter <= 0) 
        {
            Losepanel.SetActive(true);
        
        }
          if (a1.identify==sqA && a2.identify == sqB && a3.identify == sqC && a4.identify == sqD ){
            Winpanel.SetActive(true);
       }
        else 
       {
        }


    }
}
