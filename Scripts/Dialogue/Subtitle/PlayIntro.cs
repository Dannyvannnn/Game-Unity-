using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayIntro : MonoBehaviour
{
    private bool played = false;
    void OnTriggerEnter(Collider other){
        

        if (other.tag == "Player" && played == false){
        Subtitles.Show("Chaos, Earth's gravity is all over the place. Regular objects are defying the laws of gravity. Our protagonist, Ker Acter, seems to be the only one unaffected, and so it is up to him to save the earth. Through some impressive investigation, Ker Acter has to obtain the legendary artifact, the MacGuffin, to reverse all the damage done to Earth. ",25f,SubtitleEffect.Fade);
        played = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
