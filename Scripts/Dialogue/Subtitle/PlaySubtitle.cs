using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySubtitle : MonoBehaviour
{


    void OnTriggerEnter(Collider other){

        Subtitles.Show("Hello World",5f,SubtitleEffect.Fade);



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
