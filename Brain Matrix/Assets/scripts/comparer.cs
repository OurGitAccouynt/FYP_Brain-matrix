using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comparer : MonoBehaviour
{
    public GameObject firstobject;
    public GameObject secondobject;



    private void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        if (firstobject.GetComponent<Material>()== secondobject.GetComponent<Material>()) 
        {
            Debug.Log("material is same");
        
        }
    }
}
