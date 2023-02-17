using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRespawn : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other){
         if (other.tag == "Player"){
        Subtitles.Show("Not like this, you cant fail when you're this close. Let's run it back",5f,SubtitleEffect.Fade);
       

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
