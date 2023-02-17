using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach to the object that ends the timer. A checkpoint.

public class EndTimer : MonoBehaviour
{

    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) 
        {
            timer.gameObject.SendMessage("Finish");
        }
    }
}
