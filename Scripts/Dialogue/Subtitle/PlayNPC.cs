using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNPC : MonoBehaviour
{
    private bool played = false;

    void OnTriggerEnter(Collider other){
         if (other.tag == "Player" && played == false){
        Subtitles.Show("Please, you have to save us. I'll open the way for you, get the MacGuffin (Press F to Interact)",5f,SubtitleEffect.Fade);
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
