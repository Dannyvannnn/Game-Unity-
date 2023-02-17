using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Attach to the object that triggers the timer

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool finished = false;
    private bool started = false;
    public GameObject player;
    private bool triggered = false;
    
    // Start is called before the first frame update

    /*private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
    } */
    void Start()
    {
        //if((!finished) && (started))
           // startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if((!finished) && (started))
        {


        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();

        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        }
        else
            return;
    }

    public void Finish() 
    {
        finished = true;
        timerText.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {if (triggered == false){
        if (other.CompareTag("Player") ) 
        {
           started = true;
          
        }

        if((!finished) && (started))
            startTime = Time.time;
     
        triggered = true;
    }
    }
}
