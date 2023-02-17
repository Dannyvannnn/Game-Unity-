using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCheckpoint2 : MonoBehaviour
{
    private bool played = false;

    void OnTriggerEnter(Collider other){
        if (other.tag == "Player" && played == false){
        Subtitles.Show("Ker Acter sees the MacGuffin, it's so close that he can almost touch it.",5f,SubtitleEffect.Fade);
        played = true;

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
