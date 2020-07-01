using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class very_Hard : MonoBehaviour
{
    public int timeleft;
    public Text timeleftui;
    public GameObject Losepanel;
    [SerializeField] public EventManager2 ev2;
    public GameObject array;

    

    
    void Start()
    {
        InvokeRepeating("TimeLeftcal", 0, 1);
        ev2 = ev2.GetComponent<EventManager2>();
        
    }

    
    void Update()
    {
        
        if (timeleft <= 0) 
        {
            Losepanel.SetActive(true);

            
                Destroy(array);
            CancelInvoke();



        }
        
    }
    public void TimeLeftcal()
    {

        timeleft--;
        timeleftui.text = timeleft.ToString();
        ev2.enabled = false;
    }
}
