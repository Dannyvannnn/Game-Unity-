using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCheckpoint1 : MonoBehaviour
{
    private bool played = false;

    void OnTriggerEnter(Collider other){
        if (other.tag == "Player" && played == false){
        Subtitles.Show("With this, Mr Acter is nearer to the MacGuffin",5f,SubtitleEffect.Fade);
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
