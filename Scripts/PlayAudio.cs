using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    private bool triggered = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && triggered == false)
        {
            audioSource.Play();
            triggered = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}