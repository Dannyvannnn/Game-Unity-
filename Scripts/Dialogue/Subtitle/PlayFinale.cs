using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFinale : MonoBehaviour
{
    private bool played = false;

    void OnTriggerEnter(Collider other){
         if (other.tag == "Player" && played == false){
        Subtitles.Show("And there it is, after a long journey, our hero gets hold of the MacGuffin. Congratulations, the Earth is saved",5f,SubtitleEffect.Fade);
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
